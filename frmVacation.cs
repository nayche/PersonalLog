using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;
using MsgBox = System.Windows.Forms.MessageBox;
using LAFP;
using System.IO;


namespace PersonalLog
{
    public partial class frmVacation : Form
    {
        private delegate void ButtonClickDelegate(object sender, EventArgs e);
        ButtonClickDelegate btnClickEventHandler;

        private delegate void DgvCellClickDelegate(object sender, DataGridViewCellEventArgs eg);
        DgvCellClickDelegate dgvCellClickEventHandler;

        private DataGridViewRow currentDgvRow = new DataGridViewRow();
        //Constructor
        public frmVacation()
        {
            InitializeComponent();
            lblLastName.Text = null;
            LoadEmployees();
            RefreshData();
        }

        // Methods

        /* Method loads the employees table without display so lblEmpName can be retreived
         * based on emplyee number */
        private void LoadEmployees()  
        {

            try
            {
                dstEmp.Employees.Clear();
                OleDbCommand cmd = new OleDbCommand("SELECT * FROM Employees", cntEmp);

                if (cntEmp.State != ConnectionState.Open)
                {
                    cntEmp.Open();
                }
                
                OleDbDataReader reader = cmd.ExecuteReader(CommandBehavior.Default);
                dstEmp.Load(reader, LoadOption.OverwriteChanges, dstEmp.Tables[0]);
                cntEmp.Close();
             
                //bsPLog.Filter = 
            }
            catch (Exception ex)
            {
                Utilities.WarningMsgBox(ex.Message);
            }
            finally
            {
                cntEmp.Close();
            }
            
        }

        private void RefreshData()
        {
            try
            {
                OleDbCommand cmd = new OleDbCommand("SELECT * FROM Vacation", cntVac);

                //string currentDateString = this.dateTimePLog.Value.ToShortDateString();

                dstPersonalLog1.Vacation.Clear();

                //open connection and fill dataset
                if (cntVac.State != ConnectionState.Open)   // guard agains already open connection
                {
                    cntVac.Open();
                }
                OleDbDataReader reader = cmd.ExecuteReader();
                dstPersonalLog1.Load(reader, LoadOption.OverwriteChanges, dstPersonalLog1.Tables[1]);
                cntVac.Close();

                //Filter date per selected date
               //bsVac.Filter = "InputDate =# " + string.Format("{0:MM/dd/yyyy}", dateTimePLog.Value) + "#"; //"Input Date = '" + currentDateString + "'";

            }
            catch (Exception ex)
            {
                Utilities.WarningMsgBox(ex.Message);
            }
            finally
            {
                cntVac.Close();
            }

            

        }
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void txtEmpID_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == char.Parse("\b"))
            {
                return;     //i.e., it allow backspace all the time since e.handle defaults to false.
            }
            else if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (txtEmpID.Text.Length == 3) { e.Handled = true; }

            // else, it will allow characters
        }

        private void frmVacation_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dstPersonalLog1.Vacation' table. You can move, or remove it, as needed.
            this.vacationTableAdapter.Fill(this.dstPersonalLog1.Vacation);
            // TODO: This line of code loads data into the 'dstPersonalLog1.Vacation' table. You can move, or remove it, as needed.
            this.vacationTableAdapter.Fill(this.dstPersonalLog1.Vacation);
            #region "Setup Components at start"

            dgvVacation.BackgroundColor = Color.White;
            dgvVacation.EditMode = DataGridViewEditMode.EditOnKeystroke;
            dgvVacation.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvVacation.ReadOnly = true;

            #endregion 
        }

        private void txtEmpID_TextChanged(object sender, EventArgs e)
        {
            if (txtEmpID.Text.Length == 3)
            {
                try
                {
                    string filterCriteria = "EmployeeID = '" + txtEmpID.Text + "'";
                    DataRow[] rows = dstEmp.Employees.Select(filterCriteria);
                    DataRow row = rows[0];
                    
                    lblLastName.Text = row[2].ToString();
                }
                catch (IndexOutOfRangeException ex)
                {
                    Utilities.WarningMsgBox("Employee number was not found.  Verify that this employee number is correct.");
                    txtEmpID.Text = null;
                }
                catch (Exception ex)
                {
                    Utilities.WarningMsgBox(ex.Message);
                }
            }
            else
            {
                lblLastName.Text = "";
            }
        }

        private void btnClearFilter_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    // check against empty records
                    if (this.txtEmpID.Text == "")
                    {
                        MsgBox.Show("Name must be provided", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    
                    // update dataset
                    DataRow dRow = dstPersonalLog1.Vacation.NewRow();
                    dRow[0] = Convert.ToInt16(txtEmpID.Text);
                    dRow[1] = lblLastName.Text;
                    dRow[2] = dateStart.Value.ToShortDateString();
                    dRow[3] = dateEnd.Value.ToShortDateString();

                    // check against existing identical record
                    bool multipleRecords = VacationMultipleRecords(dRow, dstPersonalLog1.Vacation);
                    if(multipleRecords)
                    {
                        Utilities.WarningMsgBox("This record already exists in the database.\n" + 
                            "Data not saved");
                        return;
                    }
                    dstPersonalLog1.Vacation.Rows.Add(dRow);
                    AddDialyLog(dRow);
                    
                    // open connection and update database
                    cntVac.Open();
                    daVac.Update(dstPersonalLog1, "Vacation");
                    cntEmp.Close();
                                        
                    RefreshData();

                }
                catch (Exception ex)
                {
                    MsgBox.Show(ex.Message);
                }
                finally
                {
                    cntVac.Close();
                }
            }
            catch (Exception ex)
            {
                Utilities.ErrorMsgBox(ex.Message);
            }
            finally
            {
                cntVac.Close();
            }

            // we need to add code to add these dates to the PersonalLog table. 
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {

        }

        private bool VacationMultipleRecords(DataRow row, DataTable table)
        {
            /* this method is to check against existing record and return a bool value indicating
             * wether this new record exiting in the databae*/

            bool multipleRecords = false;

            foreach (DataRow rw in table.Rows)
            {
                if (row[0].ToString() == rw[0].ToString() && row[1].ToString() == rw[1].ToString() && row[2].ToString() == rw[2].ToString() && row[3].ToString() == rw[3].ToString() )
                {
                    multipleRecords = true;
                }
            }

            return multipleRecords;
        }

        private void dgvVacation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvVacation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            currentDgvRow = dgvVacation.CurrentRow;
            try
            {
                if (this.dgvVacation.CurrentRow.IsNewRow) return;

                this.txtEmpID.Text = this.dgvVacation.CurrentRow.Cells[0].Value.ToString();
                this.lblLastName.Text = this.dgvVacation.CurrentRow.Cells[1].Value.ToString();
                this.dateStart.Value = Convert.ToDateTime(this.dgvVacation.CurrentRow.Cells[2].Value);
                this.dateEnd.Value = Convert.ToDateTime(this.dgvVacation.CurrentRow.Cells[3].Value);
                //this.dateTimePLog.Value = (DateTime)this.gridlinePLog.CurrentRow.Cells[4].Value;
            }
            catch (Exception ex)
            {
                Utilities.ErrorMsgBox(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    #region "Checks"
                    // check agains empty table
                    if (this.dgvVacation.Rows.Count == 0)
                    {
                        MsgBox.Show("There are no available records to delete", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    // check agains selecting multiple rows (this feature is disabled and probalby this code is not necessary
                    if (this.dgvVacation.SelectedRows.Count != 1 && this.dgvVacation.SelectedRows.Count != 0)
                    {
                        MsgBox.Show("Select one record only for deletion", Application.ProductName);
                        return;
                    }
                    // think about this part
                    if (!this.dgvVacation.Focus())
                    {
                        MsgBox.Show("Select only one data record for deletion", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    #endregion

                    int currentdgvRowIndex = this.dgvVacation.CurrentRow.Index;
                    DataRow dRow = CurrentDataRow(dgvVacation.CurrentRow, dgvVacation);
                    int currentRowIndex = dstPersonalLog1.Vacation.Rows.IndexOf(dRow);
                    dstPersonalLog1.Vacation.Rows[currentRowIndex].Delete();

                    // open connection and execute the dataadapter delete command
                    cntVac.Open();
                    daVac.Update(dstPersonalLog1, "Vacation");
                    cntVac.Close();

                    // refresh data and set focus to current row
                    RefreshData();
                    this.dgvVacation.Rows[currentdgvRowIndex - 1].Cells[0].Selected = true;

                }
                catch (Exception ex)
                {
                    MsgBox.Show(ex.Message);
                }
                finally
                {
                    cntVac.Close();
                }

            }
            catch (Exception ex)
            {
                Utilities.ErrorMsgBox(ex.Message);
            }
            finally
            {
                cntVac.Close();
            }
        }


        private DataRow CurrentDataRow(DataGridViewRow dgvRow, DataGridView dGridView)
        {
            /*  The binding source is filtered by date.  due to this, the row shown in the datagridview are not all the 
             * rows in the datatable.  The row index in the datagridview does not reflect the actual row index in the 
             * datatable.  For this problem, we have to create this method to return the actual row in the datatable so 
             * we modify the right row.  Using the index of row in datagridview will lead to modifiying a different row. */

            //DateTime currentDate = (DateTime)dgvRow.Cells[4].Value;  //?

            string filterCriteria = "EmpID = '" + dgvRow.Cells[0].Value.ToString() +
                "' AND EmployeeName = '" + dgvRow.Cells[1].Value.ToString() +
                "' AND StartDate = '" + dgvRow.Cells[2].Value.ToString() +
                "' AND EndDate = '" + dgvRow.Cells[3].Value.ToString() +"'";

            DataRow[] rows = dstPersonalLog1.Vacation.Select(filterCriteria);
            DataRow row = rows[0];
            return row;
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            try
            {
                // check against rows not being selected or empty table
                if (this.dgvVacation.Rows.Count == 0 || this.dgvVacation.SelectedRows.Count > 1)
                {
                    MsgBox.Show("There are no selected records to modify", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                int currentdgvRowIndex = this.dgvVacation.CurrentRow.Index;         // to be used to select this row after refresh

                DataRow dRow = CurrentDataRow(currentDgvRow, dgvVacation);

                DataRow dRowTemp = dstPersonalLog1.Vacation.NewRow();    // In case the new modified row matches an existing row, this way it would not update the row in the dataset
                dRowTemp[0] = txtEmpID.Text;
                dRowTemp[1] = lblLastName.Text;
                dRowTemp[2] = dateStart.Value.ToShortDateString();
                dRowTemp[3] = dateEnd.Value.ToShortDateString();


                // check against multiple row
                bool mulRecords = VacationMultipleRecords(dRowTemp, dstPersonalLog1.Vacation);
                if (mulRecords)
                {
                    Utilities.WarningMsgBox("This record already exists in the database.\n" +
                            "Data not saved");
                    dgvCellClickEventHandler = new DgvCellClickDelegate(dgvVacation_CellClick);
                    dgvCellClickEventHandler.Invoke(dgvVacation, new DataGridViewCellEventArgs(1, 1));

                    return;
                }
                dRow[0] = dRowTemp[0];
                dRow[1] = dRowTemp[1];
                dRow[2] = dRowTemp[2];
                dRow[3] = dRowTemp[3];
                // open connection and apply changes
                cntVac.Open();
                daVac.Update(dstPersonalLog1, "Vacation");
                cntVac.Close();

                // refresh data and set focus to current row
                //this.RefreshData();
                this.dgvVacation.Rows[currentdgvRowIndex].Cells[0].Selected = true;

            }
            catch (Exception ex)
            {
                Utilities.ErrorMsgBox(ex.Message + "\n" + ex.StackTrace);
            }
            finally
            {
                cntVac.Close();
            }

        }

        ////private void mSExcelToolStripMenuItem_Click(object sender, EventArgs e)
        ////{
        ////    DataTable dt = this.dstPersonalLog1.Vacation;
        ////    // Exporting to csv is no big deal, we do it anyway
        ////    SaveFileDialog sfd = new SaveFileDialog();
        ////    sfd.FileName = "results.csv";

        ////    if (sfd.ShowDialog() != System.Windows.Forms.DialogResult.OK)
        ////    {
        ////        return;
        ////    }

        ////    StreamWriter sw = new StreamWriter(sfd.FileName, false);

        ////    string fileRow = "";
        ////    string cell = "";

        ////    // lets get the dataColumn's titles first
        ////    string titles = "";
        ////    for (int x = 0; x < dt.Columns.Count; x++)
        ////    {
        ////        titles += dt.Columns[x].ColumnName + ",";
        ////    }
        ////    sw.WriteLine(titles);

        ////    // and then we go for the data
        ////    for (int i = 0; i < dt.Rows.Count; i++)
        ////    {
        ////        fileRow = "";
        ////        cell = "";

        ////        for (int j = 0; j < dt.Rows[i].ItemArray.Length; j++)
        ////        {
        ////            cell = dt.Rows[i][j].ToString();

        ////            if (cell == null)
        ////            {
        ////                cell = "";
        ////            }

        ////            // if the data contains a comma,
        ////            // we enclose that cell with "" so the excel
        ////            // will understand that comma is not a column separator
        ////            if (cell.Contains(","))
        ////            {
        ////                cell = "\"" + cell + "\"";
        ////            }

        ////            fileRow += cell + ",";
        ////        }


        ////        sw.WriteLine(fileRow);
        ////    }

        ////    sw.Close();
        ////}




        private void AddDialyLog(DataRow row)  // the current row that is been added to the Vacation table.
        {
            try
            {
                DateTime dtStart = this.dateStart.Value;
                DateTime dtEnd = this.dateEnd.Value;

                while (dtStart <= dtEnd)
                {
                    DataRow newRow = dstPersonalLog1.PersonalLog.NewRow();
                    newRow[0] = row[1];
                    newRow[1] = "Vacation";
                    newRow[2] = row[2];
                    newRow[3] = row[3];
                    newRow[4] = dtStart;
                    newRow[5] = true;

                    dstPersonalLog1.PersonalLog.Rows.Add(newRow);

                    dtStart = dtStart.AddDays(1);
                }

                if (cntVac.State != ConnectionState.Open)
                {
                    cntVac.Open();
                }
                daLog.Update(dstPersonalLog1, "PersonalLog");
                cntVac.Close();
            }
            catch (Exception ex)
            {
                Utilities.ErrorMsgBox(ex.Message);
            }
            finally
            {
                cntVac.Close();
            }

        }
     




    }
}
