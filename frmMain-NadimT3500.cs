using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using MsgBox = System.Windows.Forms.MessageBox;
using System.Drawing;
using LAFP;


namespace PersonalLog
{
    public partial class frmMain : Form
    {
        private delegate void ButtonClickDelegate(object sender, EventArgs e);
        ButtonClickDelegate btnClickEventHandler;
        private DataGridViewRow currentDgvRow = new DataGridViewRow();
        
        public frmMain()
        {
            InitializeComponent();
            btnClickEventHandler = new ButtonClickDelegate(btnClearFilter_Click);
        }

        private void RefreshData()
        {
            try
            {
                OleDbCommand cmd = new OleDbCommand("SELECT * FROM PersonalLog", cntPLog);


                string currentDateString = this.dateTimePLog.Value.ToShortDateString();

                dstPLog1.PersonalLog.Clear();

                //open connection and fill dataset
                if (cntPLog.State != ConnectionState.Open)   // guard agains already open connection
                {
                    cntPLog.Open();
                }
                OleDbDataReader reader = cmd.ExecuteReader();
                dstPLog1.Load(reader, LoadOption.OverwriteChanges, dstPLog1.Tables[0]);
                cntPLog.Close();

                //Filter date per selected date
                bsPLog.Filter = "InputDate =# " + string.Format("{0:MM/dd/yyyy}", dateTimePLog.Value) + "#"; //"Input Date = '" + currentDateString + "'";
                
            }
            catch (Exception ex)
            {
                MsgBox.Show(ex.Message);
            }
            finally
            {
                cntPLog.Close();
            }
            
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            #region "Setup Components at start"

            dgvPLog.BackgroundColor = Color.White;
            dgvPLog.EditMode = DataGridViewEditMode.EditOnKeystroke;
            dgvPLog.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvPLog.ReadOnly = true;


            #endregion 
          
            try
            {
                // fill dataset, table, and datagrid
                RefreshData();

                // setting up the dateTimePicker to today's date
                this.dateTimePLog.Value = DateTime.Today;

                // populate the time texts with a string of current time
                DateTime currentTime = DateTime.Now;

                string currentTimeString = currentTime.ToShortTimeString();
                this.txtTimeOut.Text = currentTimeString;
                this.txtReturnTime.Text = currentTimeString;

                //send focus to txtName
                this.txtName.Focus();

                
                
            }
            catch (Exception ex)
            {
                Utilities.ErrorMsgBox(ex.Message);   
            }
            finally
            {
                cntPLog.Close();
            }
        }

       
        private void bntSave_Click_1(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    // check against empty records
                    if (this.txtName.Text == "")
                    {
                        MsgBox.Show("Name or ID must be provided", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    
                    // update dataset
                    DataRow dRow = dstPLog1.PersonalLog.NewRow();
                    dRow[0] = txtName.Text;
                    dRow[1] = txtDestination.Text;
                    dRow[2] = txtTimeOut.Text;
                    dRow[3] = txtReturnTime.Text;
                    dRow[4] = dateTimePLog.Value.ToShortDateString();

                    // check against existing identical record
                    if(MultipleRecords(dRow, dstPLog1.PersonalLog))
                    {
                        Utilities.WarningMsgBox("This record already exists in the database.\n" + 
                            "Data not saved");
                        return;
                    }
                    dstPLog1.PersonalLog.Rows.Add(dRow);
                    
                    // open connection and update database
                    cntPLog.Open();
                    daPLog.Update(dstPLog1, "PersonalLog");
                    cntPLog.Close();

                    RefreshData();
                }
                catch (Exception ex)
                {
                    MsgBox.Show(ex.Message);
                }
                finally
                {
                    cntPLog.Close();
                }
            }
            catch (Exception ex)
            {
                Utilities.ErrorMsgBox(ex.Message);
            }
            finally
            {
                cntPLog.Close();
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            try
            {
                // check against rows not being selected or empty table
                if (dgvPLog.Rows.Count == 0 || dgvPLog.SelectedRows.Count > 1)
                {
                    MsgBox.Show("There are no selected records to modify", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                int currentdgvRowIndex = dgvPLog.CurrentRow.Index;         // to be used to select this row after refresh

                DataRow dRow = CurrentDataRow(currentDgvRow, dgvPLog);

                dRow[0] = txtName.Text;
                dRow[1] = txtDestination.Text;
                dRow[2] = txtTimeOut.Text;
                dRow[3] = txtReturnTime.Text;
                dRow[4] = dateTimePLog.Value.ToShortDateString();

                // check against existing identical record
                if (MultipleRecords(dRow, dstPLog1.PersonalLog))
                {
                    //Utilities.WarningMsgBox("This record already exists in the database.\n" + "Data not saved");
                    MsgBox.Show("This record already exists in the database.\n" + "Data not saved");
                    return;
                }

           
                // open connection and apply changes
                cntPLog.Open();
                daPLog.Update(dstPLog1, "PersonalLog");
                cntPLog.Close();

                // refresh data and set focus to current row
                //this.RefreshData();
                this.dgvPLog.Rows[currentdgvRowIndex].Cells[0].Selected = true;
                    
            }
            catch (Exception ex)
            {
                Utilities.ErrorMsgBox(ex.Message + "\n" + ex.StackTrace);
            }
            finally
            {
                cntPLog.Close();
            }

        }

        private bool CheckTextNotBlank()
        {
            if(this.txtName.Text == "" )
            {
                return true;
            }
            return false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    #region "Checks"
                    // check agains empty table
                    if (dgvPLog.Rows.Count == 0)
                    {
                        MsgBox.Show("There are no available records to delete", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    // check agains selecting multiple rows (this feature is disabled and probalby this code is not necessary
                    if (dgvPLog.SelectedRows.Count != 1 && dgvPLog.SelectedRows.Count != 0)
                    {
                        MsgBox.Show("Select one record only for deletion", Application.ProductName);
                        return;
                    }
                    // think about this part
                    if (!this.dgvPLog.Focus())
                    {
                        MsgBox.Show("Select only one data record for deletion", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    #endregion

                    int currentdgvRowIndex = this.dgvPLog.CurrentRow.Index;
                    DataRow dRow = CurrentDataRow(dgvPLog.CurrentRow, dgvPLog);
                    int currentRowIndex = dstPLog1.PersonalLog.Rows.IndexOf(dRow);
                    dstPLog1.PersonalLog.Rows[currentRowIndex].Delete();

                    // open connection and execute the dataadapter delete command
                    cntPLog.Open();
                    daPLog.Update(dstPLog1, "PersonalLog");
                    cntPLog.Close();

                    // refresh data and set focus to current row
                    RefreshData();
                    this.dgvPLog.Rows[currentdgvRowIndex - 1].Cells[0].Selected = true;


                }
                catch (Exception ex)
                {
                    MsgBox.Show(ex.Message);
                }
                finally
                {
                    cntPLog.Close();
                }

            }
            catch (Exception ex)
            {
                Utilities.ErrorMsgBox(ex.Message);
            }
            finally
            {
                cntPLog.Close();
            }
        }

 

       private void mnuClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dateTimePLog_ValueChanged(object sender, EventArgs e)
        {
               //RefreshData();
            bsPLog.Filter = "InputDate =# " + string.Format("{0:MM/dd/yyyy}", dateTimePLog.Value) + "#"; 
        }
                

        private void dgvPLog_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            currentDgvRow = dgvPLog.CurrentRow;
            try
            {
                if (this.dgvPLog.CurrentRow.IsNewRow) return;

                this.txtName.Text = this.dgvPLog.CurrentRow.Cells[0].Value.ToString();
                this.txtDestination.Text = this.dgvPLog.CurrentRow.Cells[1].Value.ToString();
                this.txtTimeOut.Text = this.dgvPLog.CurrentRow.Cells[2].Value.ToString();
                this.txtReturnTime.Text = this.dgvPLog.CurrentRow.Cells[3].Value.ToString();
                //this.dateTimePLog.Value = (DateTime)this.gridlinePLog.CurrentRow.Cells[4].Value;
            }
            catch (Exception ex)
            {
                Utilities.ErrorMsgBox(ex.Message);
            }
        }

     



        private DataRow CurrentDataRow(DataGridViewRow dgvRow, DataGridView dGridView)
        {
            /*  The binding source is filtered by date.  due to this, the row shown in the datagridview are not all the 
             * rows in the datatable.  The row index in the datagridview does not reflect the actual row index in the 
             * datatable.  For this problem, we have to create this method to return the actual row in the datatable so 
             * we modify the right row.  Using the index of row in datagridview will lead to modifiying a different row. */
             
            DateTime currentDate = (DateTime)dgvRow.Cells[4].Value;

            string filterCriteria = "EmployeeName = '" + dgvRow.Cells[0].Value.ToString() +
                "' AND Destination = '" + dgvRow.Cells[1].Value.ToString() +
                "' AND TimeOut = '" + dgvRow.Cells[2].Value.ToString() +
                "' AND ReturnTime = '" + dgvRow.Cells[3].Value.ToString() +
                "' AND InputDate = #" + currentDate.ToShortDateString() + "#";

            DataRow[] rows = dstPLog1.PersonalLog.Select(filterCriteria);
            DataRow row = rows[0];
            return row;
        }

        private bool MultipleRecords(DataRow row, DataTable table)
        {
            /* this method is to check against existing record and return a bool value indicating
             * wether this new record exiting in the databae*/

            bool multipleRecords = false;

            foreach (DataRow rw in table.Rows)
            {
                if (row[0].ToString() == rw[0].ToString() && row[1].ToString() == rw[1].ToString() && row[2].ToString() == rw[2].ToString() && row[3].ToString() == rw[3].ToString() && row[4].ToString() == rw[04].ToString())
                {
                    multipleRecords = true; 
                }
            }

            return multipleRecords;
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            if (txtFilter.Text != "")
            {
                // debug, bsPLog.Filter raises the dateTimePicker change event
                // investigate that.  It doesn't work with gc filter

                string currentDateString = this.dateTimePLog.Value.ToShortDateString();
                
                bsPLog.Filter = "EmployeeName LIKE '%" + txtFilter.Text + "%' " +
                    "AND InputDate =#" + string.Format("{0:MM/dd/yyyy}", dateTimePLog.Value) + "#"; //"Input Date = '" + currentDateString + "'";
            }
            else
            {
                btnClickEventHandler.Invoke(btnClearFilter, EventArgs.Empty);
            }

        }

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            txtFilter.Text = "";
            bsPLog.RemoveFilter();

            // reaply filter
            string currentDateString = this.dateTimePLog.Value.ToShortDateString();
            bsPLog.Filter = "InputDate =#" + string.Format("{0:MM/dd/yyyy}", dateTimePLog.Value) + "#"; //"Input Date = '" + currentDateString + "'";
        }

        private void btnDaySubtract_Click(object sender, EventArgs e)
        {
            dateTimePLog.Value = dateTimePLog.Value.AddDays(-1);
        }

        private void btnDayAdd_Click(object sender, EventArgs e)
        {
            dateTimePLog.Value = dateTimePLog.Value.AddDays(1);
        }

        private void vacCalcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVacation frm = new frmVacation();
            frm.ShowDialog();

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        
      
        

      
    }
}
