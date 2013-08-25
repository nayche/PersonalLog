namespace PersonalLog
{
    partial class frmVacation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVacation));
            this.mnu = new System.Windows.Forms.MenuStrip();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mSWordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mSExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvVacation = new System.Windows.Forms.DataGridView();
            this.empIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsVac = new System.Windows.Forms.BindingSource(this.components);
            this.dstPersonalLog1 = new PersonalLog.dstPersonalLog();
            this.btnClearFilter = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblLastName = new System.Windows.Forms.Label();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.cntVac = new System.Data.OleDb.OleDbConnection();
            this.cntEmp = new System.Data.OleDb.OleDbConnection();
            this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
            this.daVac = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbCommand2 = new System.Data.OleDb.OleDbCommand();
            this.oleDbCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbCommand3 = new System.Data.OleDb.OleDbCommand();
            this.txtEmpID = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.daLog = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbDeleteCommand = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand2 = new System.Data.OleDb.OleDbCommand();
            this.oleDbSelectCommand2 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand = new System.Data.OleDb.OleDbCommand();
            this.dstEmp = new PersonalLog.dstEmployees();
            this.vacationTableAdapter = new PersonalLog.dstPersonalLogTableAdapters.VacationTableAdapter();
            this.mnu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVacation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dstPersonalLog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dstEmp)).BeginInit();
            this.SuspendLayout();
            // 
            // mnu
            // 
            this.mnu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.chartToolStripMenuItem});
            this.mnu.Location = new System.Drawing.Point(0, 0);
            this.mnu.Name = "mnu";
            this.mnu.Size = new System.Drawing.Size(584, 24);
            this.mnu.TabIndex = 0;
            this.mnu.Text = "menuStrip1";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mSWordToolStripMenuItem,
            this.mSExcelToolStripMenuItem});
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // mSWordToolStripMenuItem
            // 
            this.mSWordToolStripMenuItem.Name = "mSWordToolStripMenuItem";
            this.mSWordToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.mSWordToolStripMenuItem.Text = "MS Word";
            // 
            // mSExcelToolStripMenuItem
            // 
            this.mSExcelToolStripMenuItem.Name = "mSExcelToolStripMenuItem";
            this.mSExcelToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.mSExcelToolStripMenuItem.Text = "MS Excel";
            // 
            // chartToolStripMenuItem
            // 
            this.chartToolStripMenuItem.Name = "chartToolStripMenuItem";
            this.chartToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.chartToolStripMenuItem.Text = "Chart";
            // 
            // dgvVacation
            // 
            this.dgvVacation.AllowUserToAddRows = false;
            this.dgvVacation.AutoGenerateColumns = false;
            this.dgvVacation.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvVacation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVacation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.empIDDataGridViewTextBoxColumn,
            this.employeeNameDataGridViewTextBoxColumn,
            this.startDateDataGridViewTextBoxColumn,
            this.endDateDataGridViewTextBoxColumn});
            this.dgvVacation.DataSource = this.bsVac;
            this.dgvVacation.Location = new System.Drawing.Point(7, 70);
            this.dgvVacation.Name = "dgvVacation";
            this.dgvVacation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVacation.Size = new System.Drawing.Size(565, 336);
            this.dgvVacation.TabIndex = 1;
            this.dgvVacation.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVacation_CellClick);
            this.dgvVacation.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVacation_CellContentClick);
            // 
            // empIDDataGridViewTextBoxColumn
            // 
            this.empIDDataGridViewTextBoxColumn.DataPropertyName = "EmpID";
            this.empIDDataGridViewTextBoxColumn.HeaderText = "EmpID";
            this.empIDDataGridViewTextBoxColumn.Name = "empIDDataGridViewTextBoxColumn";
            this.empIDDataGridViewTextBoxColumn.Width = 80;
            // 
            // employeeNameDataGridViewTextBoxColumn
            // 
            this.employeeNameDataGridViewTextBoxColumn.DataPropertyName = "EmployeeName";
            this.employeeNameDataGridViewTextBoxColumn.HeaderText = "EmployeeName";
            this.employeeNameDataGridViewTextBoxColumn.Name = "employeeNameDataGridViewTextBoxColumn";
            this.employeeNameDataGridViewTextBoxColumn.Width = 140;
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            this.startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
            this.startDateDataGridViewTextBoxColumn.HeaderText = "StartDate";
            this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            this.startDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // endDateDataGridViewTextBoxColumn
            // 
            this.endDateDataGridViewTextBoxColumn.DataPropertyName = "EndDate";
            this.endDateDataGridViewTextBoxColumn.HeaderText = "EndDate";
            this.endDateDataGridViewTextBoxColumn.Name = "endDateDataGridViewTextBoxColumn";
            this.endDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // bsVac
            // 
            this.bsVac.DataMember = "Vacation";
            this.bsVac.DataSource = this.dstPersonalLog1;
            // 
            // dstPersonalLog1
            // 
            this.dstPersonalLog1.DataSetName = "dstPersonalLog";
            this.dstPersonalLog1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnClearFilter
            // 
            this.btnClearFilter.Location = new System.Drawing.Point(175, 42);
            this.btnClearFilter.Name = "btnClearFilter";
            this.btnClearFilter.Size = new System.Drawing.Size(75, 23);
            this.btnClearFilter.TabIndex = 19;
            this.btnClearFilter.Text = "Clear";
            this.btnClearFilter.UseVisualStyleBackColor = true;
            this.btnClearFilter.Visible = false;
            this.btnClearFilter.Click += new System.EventHandler(this.btnClearFilter_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Name Filter";
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(69, 44);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(100, 20);
            this.txtFilter.TabIndex = 17;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(329, 412);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(181, 53);
            this.txtNote.TabIndex = 23;
            this.txtNote.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 419);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Emp ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 449);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Start Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 479);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "End Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(293, 412);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Note";
            this.label4.Visible = false;
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(341, 475);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 28;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(434, 475);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 29;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(177, 419);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(48, 13);
            this.lblLastName.TabIndex = 31;
            this.lblLastName.Text = "Emp ID";
            // 
            // dateStart
            // 
            this.dateStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateStart.Location = new System.Drawing.Point(71, 443);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(100, 20);
            this.dateStart.TabIndex = 32;
            // 
            // dateEnd
            // 
            this.dateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateEnd.Location = new System.Drawing.Point(71, 474);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(100, 20);
            this.dateEnd.TabIndex = 33;
            // 
            // cntVac
            // 
            this.cntVac.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"C:\\Users\\nayche\\SkyDrive\\LAFP\\06 D" +
    "evelopment\\Personal Log.accdb\"";
            // 
            // cntEmp
            // 
            this.cntEmp.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"C:\\Users\\nayche\\SkyDrive\\LAFP\\06 D" +
    "evelopment\\Employees.accdb\"";
            // 
            // oleDbSelectCommand1
            // 
            this.oleDbSelectCommand1.CommandText = "SELECT        Vacation.*\r\nFROM            Vacation";
            this.oleDbSelectCommand1.Connection = this.cntVac;
            // 
            // daVac
            // 
            this.daVac.DeleteCommand = this.oleDbCommand2;
            this.daVac.InsertCommand = this.oleDbCommand1;
            this.daVac.SelectCommand = this.oleDbSelectCommand1;
            this.daVac.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "PersonalLog", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("PersonalLog.EmployeeName", "PersonalLog.EmployeeName"),
                        new System.Data.Common.DataColumnMapping("Destination", "Destination"),
                        new System.Data.Common.DataColumnMapping("TimeOut", "TimeOut"),
                        new System.Data.Common.DataColumnMapping("ReturnTime", "ReturnTime"),
                        new System.Data.Common.DataColumnMapping("InputDate", "InputDate"),
                        new System.Data.Common.DataColumnMapping("EmpID", "EmpID"),
                        new System.Data.Common.DataColumnMapping("Vacation.EmployeeName", "Vacation.EmployeeName"),
                        new System.Data.Common.DataColumnMapping("StartDate", "StartDate"),
                        new System.Data.Common.DataColumnMapping("EndDate", "EndDate")})});
            this.daVac.UpdateCommand = this.oleDbCommand3;
            // 
            // oleDbCommand2
            // 
            this.oleDbCommand2.CommandText = "DELETE FROM Vacation\r\nWHERE        (EmpID = ?) AND (EmployeeName = ?) AND (StartD" +
    "ate = ?) AND (EndDate = ?)";
            this.oleDbCommand2.Connection = this.cntVac;
            this.oleDbCommand2.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("EmpID", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EmpID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("EmployeeName", System.Data.OleDb.OleDbType.WChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EmployeeName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("StartDate", System.Data.OleDb.OleDbType.Date, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "StartDate", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("EndDate", System.Data.OleDb.OleDbType.Date, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EndDate", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbCommand1
            // 
            this.oleDbCommand1.CommandText = "INSERT INTO Vacation\r\n                         (EmpID, EmployeeName, StartDate, E" +
    "ndDate)\r\nVALUES        (?, ?, ?, ?)";
            this.oleDbCommand1.Connection = this.cntVac;
            this.oleDbCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("EmpID", System.Data.OleDb.OleDbType.SmallInt, 0, "EmpID"),
            new System.Data.OleDb.OleDbParameter("EmployeeName", System.Data.OleDb.OleDbType.WChar, 255, "EmployeeName"),
            new System.Data.OleDb.OleDbParameter("StartDate", System.Data.OleDb.OleDbType.Date, 0, "StartDate"),
            new System.Data.OleDb.OleDbParameter("EndDate", System.Data.OleDb.OleDbType.Date, 0, "EndDate")});
            // 
            // oleDbCommand3
            // 
            this.oleDbCommand3.CommandText = "UPDATE       Vacation\r\nSET                EmpID = ?, EmployeeName = ?, StartDate " +
    "= ?, EndDate = ?\r\nWHERE        (EmpID = ?) AND (EmployeeName = ?) AND (StartDate" +
    " = ?) AND (EndDate = ?)";
            this.oleDbCommand3.Connection = this.cntVac;
            this.oleDbCommand3.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("EmpID", System.Data.OleDb.OleDbType.SmallInt, 0, "EmpID"),
            new System.Data.OleDb.OleDbParameter("EmployeeName", System.Data.OleDb.OleDbType.WChar, 255, "EmployeeName"),
            new System.Data.OleDb.OleDbParameter("StartDate", System.Data.OleDb.OleDbType.Date, 0, "StartDate"),
            new System.Data.OleDb.OleDbParameter("EndDate", System.Data.OleDb.OleDbType.Date, 0, "EndDate"),
            new System.Data.OleDb.OleDbParameter("Original_EmpID", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EmpID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_EmployeeName", System.Data.OleDb.OleDbType.WChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EmployeeName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_StartDate", System.Data.OleDb.OleDbType.Date, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "StartDate", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_EndDate", System.Data.OleDb.OleDbType.Date, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EndDate", System.Data.DataRowVersion.Original, null)});
            // 
            // txtEmpID
            // 
            this.txtEmpID.Location = new System.Drawing.Point(71, 416);
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.Size = new System.Drawing.Size(100, 20);
            this.txtEmpID.TabIndex = 34;
            this.txtEmpID.TextChanged += new System.EventHandler(this.txtEmpID_TextChanged);
            this.txtEmpID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmpID_KeyPress_1);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(248, 474);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 35;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // daLog
            // 
            this.daLog.DeleteCommand = this.oleDbDeleteCommand;
            this.daLog.InsertCommand = this.oleDbInsertCommand2;
            this.daLog.SelectCommand = this.oleDbSelectCommand2;
            this.daLog.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "tblPersonalLog", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("EmployeeName", "EmployeeName"),
                        new System.Data.Common.DataColumnMapping("TimeOut", "TimeOut"),
                        new System.Data.Common.DataColumnMapping("ReturnTime", "ReturnTime"),
                        new System.Data.Common.DataColumnMapping("Destination", "Destination"),
                        new System.Data.Common.DataColumnMapping("InputDate", "InputDate")})});
            this.daLog.UpdateCommand = this.oleDbUpdateCommand;
            // 
            // oleDbDeleteCommand
            // 
            this.oleDbDeleteCommand.CommandText = "DELETE FROM PersonalLog\r\nWHERE        (EmployeeName = ?) AND (TimeOut = ?) AND (R" +
    "eturnTime = ?) AND (Destination = ?) AND (InputDate = ?)";
            this.oleDbDeleteCommand.Connection = this.cntVac;
            this.oleDbDeleteCommand.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("EmployeeName", System.Data.OleDb.OleDbType.WChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EmployeeName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("TimeOut", System.Data.OleDb.OleDbType.WChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "TimeOut", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("ReturnTime", System.Data.OleDb.OleDbType.WChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ReturnTime", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Destination", System.Data.OleDb.OleDbType.WChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Destination", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("InputDate", System.Data.OleDb.OleDbType.Date, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "InputDate", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbInsertCommand2
            // 
            this.oleDbInsertCommand2.CommandText = "INSERT INTO PersonalLog\r\n                         (EmployeeName, TimeOut, ReturnT" +
    "ime, Destination, InputDate)\r\nVALUES        (?, ?, ?, ?, ?)";
            this.oleDbInsertCommand2.Connection = this.cntVac;
            this.oleDbInsertCommand2.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("EmployeeName", System.Data.OleDb.OleDbType.WChar, 255, "EmployeeName"),
            new System.Data.OleDb.OleDbParameter("TimeOut", System.Data.OleDb.OleDbType.WChar, 255, "TimeOut"),
            new System.Data.OleDb.OleDbParameter("ReturnTime", System.Data.OleDb.OleDbType.WChar, 255, "ReturnTime"),
            new System.Data.OleDb.OleDbParameter("Destination", System.Data.OleDb.OleDbType.WChar, 255, "Destination"),
            new System.Data.OleDb.OleDbParameter("InputDate", System.Data.OleDb.OleDbType.Date, 0, "InputDate")});
            // 
            // oleDbSelectCommand2
            // 
            this.oleDbSelectCommand2.CommandText = "SELECT        EmployeeName, Destination, TimeOut, ReturnTime, InputDate\r\nFROM    " +
    "        PersonalLog";
            this.oleDbSelectCommand2.Connection = this.cntVac;
            // 
            // oleDbUpdateCommand
            // 
            this.oleDbUpdateCommand.CommandText = resources.GetString("oleDbUpdateCommand.CommandText");
            this.oleDbUpdateCommand.Connection = this.cntVac;
            this.oleDbUpdateCommand.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("EmployeeName", System.Data.OleDb.OleDbType.WChar, 255, "EmployeeName"),
            new System.Data.OleDb.OleDbParameter("Destination", System.Data.OleDb.OleDbType.WChar, 255, "Destination"),
            new System.Data.OleDb.OleDbParameter("TimeOut", System.Data.OleDb.OleDbType.WChar, 255, "TimeOut"),
            new System.Data.OleDb.OleDbParameter("ReturnTime", System.Data.OleDb.OleDbType.WChar, 255, "ReturnTime"),
            new System.Data.OleDb.OleDbParameter("InputDate", System.Data.OleDb.OleDbType.Date, 0, "InputDate"),
            new System.Data.OleDb.OleDbParameter("Original_EmployeeName", System.Data.OleDb.OleDbType.WChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EmployeeName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Destination", System.Data.OleDb.OleDbType.WChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Destination", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_TimeOut", System.Data.OleDb.OleDbType.WChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "TimeOut", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_ReturnTime", System.Data.OleDb.OleDbType.WChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ReturnTime", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_InputDate", System.Data.OleDb.OleDbType.Date, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "InputDate", System.Data.DataRowVersion.Original, null)});
            // 
            // dstEmp
            // 
            this.dstEmp.DataSetName = "dstEmployees";
            this.dstEmp.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vacationTableAdapter
            // 
            this.vacationTableAdapter.ClearBeforeFill = true;
            // 
            // frmVacation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 512);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtEmpID);
            this.Controls.Add(this.dateEnd);
            this.Controls.Add(this.dateStart);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.btnClearFilter);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.dgvVacation);
            this.Controls.Add(this.mnu);
            this.MainMenuStrip = this.mnu;
            this.MaximizeBox = false;
            this.Name = "frmVacation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vacation Scheduler";
            this.Load += new System.EventHandler(this.frmVacation_Load);
            this.mnu.ResumeLayout(false);
            this.mnu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVacation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dstPersonalLog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dstEmp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnu;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mSWordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mSExcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chartToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvVacation;
        private System.Windows.Forms.Button btnClearFilter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.DateTimePicker dateStart;
        private System.Windows.Forms.DateTimePicker dateEnd;
        private System.Data.OleDb.OleDbConnection cntVac;
        private System.Data.OleDb.OleDbConnection cntEmp;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
        private System.Data.OleDb.OleDbDataAdapter daVac;
        private System.Windows.Forms.TextBox txtEmpID;
        private dstEmployees dstEmp;
        private System.Data.OleDb.OleDbCommand oleDbCommand1;
        private System.Data.OleDb.OleDbCommand oleDbCommand2;
        private System.Data.OleDb.OleDbCommand oleDbCommand3;
        private System.Windows.Forms.Button btnSave;
        private System.Data.OleDb.OleDbDataAdapter daLog;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand2;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand2;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand;
        private dstPersonalLog dstPersonalLog1;
        private System.Windows.Forms.BindingSource bsVac;
        private dstPersonalLogTableAdapters.VacationTableAdapter vacationTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn empIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
    }
}