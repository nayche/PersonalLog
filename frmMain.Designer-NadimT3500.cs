namespace PersonalLog
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.dateTimePLog = new System.Windows.Forms.DateTimePicker();
            this.txtReturnTime = new System.Windows.Forms.TextBox();
            this.txtTimeOut = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.bntSave = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.oleDbSelectCommand2 = new System.Data.OleDb.OleDbCommand();
            this.cntPLog = new System.Data.OleDb.OleDbConnection();
            this.oleDbInsertCommand2 = new System.Data.OleDb.OleDbCommand();
            this.daPLog = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbDeleteCommand = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand = new System.Data.OleDb.OleDbCommand();
            this.dgvPLog = new System.Windows.Forms.DataGridView();
            this.employeeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeOutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InputDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsPLog = new System.Windows.Forms.BindingSource(this.components);
            this.dstPLog1 = new PersonalLog.dstPLog();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuClose = new System.Windows.Forms.ToolStripMenuItem();
            this.vacCalcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnClearFilter = new System.Windows.Forms.Button();
            this.btnDayAdd = new System.Windows.Forms.Button();
            this.btnDaySubtract = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dstPLog1)).BeginInit();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePLog
            // 
            this.dateTimePLog.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePLog.CustomFormat = "";
            this.dateTimePLog.Location = new System.Drawing.Point(338, 55);
            this.dateTimePLog.Name = "dateTimePLog";
            this.dateTimePLog.Size = new System.Drawing.Size(190, 20);
            this.dateTimePLog.TabIndex = 1;
            this.dateTimePLog.TabStop = false;
            this.dateTimePLog.ValueChanged += new System.EventHandler(this.dateTimePLog_ValueChanged);
            // 
            // txtReturnTime
            // 
            this.txtReturnTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReturnTime.Location = new System.Drawing.Point(232, 428);
            this.txtReturnTime.Name = "txtReturnTime";
            this.txtReturnTime.Size = new System.Drawing.Size(100, 20);
            this.txtReturnTime.TabIndex = 2;
            // 
            // txtTimeOut
            // 
            this.txtTimeOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTimeOut.Location = new System.Drawing.Point(124, 428);
            this.txtTimeOut.Name = "txtTimeOut";
            this.txtTimeOut.Size = new System.Drawing.Size(100, 20);
            this.txtTimeOut.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Location = new System.Drawing.Point(16, 428);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 0;
            // 
            // txtDestination
            // 
            this.txtDestination.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDestination.Location = new System.Drawing.Point(16, 475);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Size = new System.Drawing.Size(316, 20);
            this.txtDestination.TabIndex = 3;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(499, 469);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(75, 20);
            this.numericUpDown1.TabIndex = 6;
            this.numericUpDown1.TabStop = false;
            this.numericUpDown1.Visible = false;
            // 
            // bntSave
            // 
            this.bntSave.Location = new System.Drawing.Point(376, 426);
            this.bntSave.Name = "bntSave";
            this.bntSave.Size = new System.Drawing.Size(80, 28);
            this.bntSave.TabIndex = 4;
            this.bntSave.Text = "Save";
            this.bntSave.UseVisualStyleBackColor = true;
            this.bntSave.Click += new System.EventHandler(this.bntSave_Click_1);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(376, 469);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(80, 28);
            this.btnModify.TabIndex = 5;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(494, 425);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 28);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.TabStop = false;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 412);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 412);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Time Out";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(267, 412);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Return Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 459);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Destination";
            // 
            // oleDbSelectCommand2
            // 
            this.oleDbSelectCommand2.CommandText = "SELECT        EmployeeName, Destination, TimeOut, ReturnTime, InputDate\r\nFROM    " +
                "        PersonalLog";
            this.oleDbSelectCommand2.Connection = this.cntPLog;
            // 
            // cntPLog
            // 
            this.cntPLog.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"C:\\Users\\nayche\\SkyDrive\\LAFP\\06 D" +
                "evelopment\\Personal Log.accdb\"";
            // 
            // oleDbInsertCommand2
            // 
            this.oleDbInsertCommand2.CommandText = "INSERT INTO PersonalLog\r\n                         (EmployeeName, TimeOut, ReturnT" +
                "ime, Destination, InputDate)\r\nVALUES        (?, ?, ?, ?, ?)";
            this.oleDbInsertCommand2.Connection = this.cntPLog;
            this.oleDbInsertCommand2.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("EmployeeName", System.Data.OleDb.OleDbType.WChar, 255, "EmployeeName"),
            new System.Data.OleDb.OleDbParameter("TimeOut", System.Data.OleDb.OleDbType.WChar, 255, "TimeOut"),
            new System.Data.OleDb.OleDbParameter("ReturnTime", System.Data.OleDb.OleDbType.WChar, 255, "ReturnTime"),
            new System.Data.OleDb.OleDbParameter("Destination", System.Data.OleDb.OleDbType.WChar, 255, "Destination"),
            new System.Data.OleDb.OleDbParameter("InputDate", System.Data.OleDb.OleDbType.Date, 0, "InputDate")});
            // 
            // daPLog
            // 
            this.daPLog.DeleteCommand = this.oleDbDeleteCommand;
            this.daPLog.InsertCommand = this.oleDbInsertCommand2;
            this.daPLog.SelectCommand = this.oleDbSelectCommand2;
            this.daPLog.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "tblPersonalLog", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("EmployeeName", "EmployeeName"),
                        new System.Data.Common.DataColumnMapping("TimeOut", "TimeOut"),
                        new System.Data.Common.DataColumnMapping("ReturnTime", "ReturnTime"),
                        new System.Data.Common.DataColumnMapping("Destination", "Destination"),
                        new System.Data.Common.DataColumnMapping("InputDate", "InputDate")})});
            this.daPLog.UpdateCommand = this.oleDbUpdateCommand;
            // 
            // oleDbDeleteCommand
            // 
            this.oleDbDeleteCommand.CommandText = "DELETE FROM PersonalLog\r\nWHERE        (EmployeeName = ?) AND (TimeOut = ?) AND (R" +
                "eturnTime = ?) AND (Destination = ?) AND (InputDate = ?)";
            this.oleDbDeleteCommand.Connection = this.cntPLog;
            this.oleDbDeleteCommand.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("EmployeeName", System.Data.OleDb.OleDbType.WChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EmployeeName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("TimeOut", System.Data.OleDb.OleDbType.WChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "TimeOut", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("ReturnTime", System.Data.OleDb.OleDbType.WChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ReturnTime", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Destination", System.Data.OleDb.OleDbType.WChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Destination", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("InputDate", System.Data.OleDb.OleDbType.Date, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "InputDate", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbUpdateCommand
            // 
            this.oleDbUpdateCommand.CommandText = resources.GetString("oleDbUpdateCommand.CommandText");
            this.oleDbUpdateCommand.Connection = this.cntPLog;
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
            // dgvPLog
            // 
            this.dgvPLog.AllowUserToAddRows = false;
            this.dgvPLog.AllowUserToDeleteRows = false;
            this.dgvPLog.AllowUserToResizeColumns = false;
            this.dgvPLog.AllowUserToResizeRows = false;
            this.dgvPLog.AutoGenerateColumns = false;
            this.dgvPLog.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPLog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeNameDataGridViewTextBoxColumn,
            this.destinationDataGridViewTextBoxColumn,
            this.timeOutDataGridViewTextBoxColumn,
            this.returnTimeDataGridViewTextBoxColumn,
            this.InputDate});
            this.dgvPLog.DataSource = this.bsPLog;
            this.dgvPLog.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dgvPLog.Location = new System.Drawing.Point(12, 87);
            this.dgvPLog.MultiSelect = false;
            this.dgvPLog.Name = "dgvPLog";
            this.dgvPLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvPLog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPLog.Size = new System.Drawing.Size(563, 309);
            this.dgvPLog.TabIndex = 7;
            this.dgvPLog.TabStop = false;
            this.dgvPLog.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPLog_CellClick);
            this.dgvPLog.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPLog_CellContentClick);
            // 
            // employeeNameDataGridViewTextBoxColumn
            // 
            this.employeeNameDataGridViewTextBoxColumn.DataPropertyName = "EmployeeName";
            this.employeeNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.employeeNameDataGridViewTextBoxColumn.Name = "employeeNameDataGridViewTextBoxColumn";
            this.employeeNameDataGridViewTextBoxColumn.Width = 120;
            // 
            // destinationDataGridViewTextBoxColumn
            // 
            this.destinationDataGridViewTextBoxColumn.DataPropertyName = "Destination";
            this.destinationDataGridViewTextBoxColumn.HeaderText = "Destination";
            this.destinationDataGridViewTextBoxColumn.Name = "destinationDataGridViewTextBoxColumn";
            this.destinationDataGridViewTextBoxColumn.Width = 200;
            // 
            // timeOutDataGridViewTextBoxColumn
            // 
            this.timeOutDataGridViewTextBoxColumn.DataPropertyName = "TimeOut";
            this.timeOutDataGridViewTextBoxColumn.HeaderText = "TimeOut";
            this.timeOutDataGridViewTextBoxColumn.Name = "timeOutDataGridViewTextBoxColumn";
            // 
            // returnTimeDataGridViewTextBoxColumn
            // 
            this.returnTimeDataGridViewTextBoxColumn.DataPropertyName = "ReturnTime";
            this.returnTimeDataGridViewTextBoxColumn.HeaderText = "ReturnTime";
            this.returnTimeDataGridViewTextBoxColumn.Name = "returnTimeDataGridViewTextBoxColumn";
            // 
            // InputDate
            // 
            this.InputDate.DataPropertyName = "InputDate";
            this.InputDate.HeaderText = "InputDate";
            this.InputDate.Name = "InputDate";
            this.InputDate.Visible = false;
            // 
            // bsPLog
            // 
            this.bsPLog.DataMember = "PersonalLog";
            this.bsPLog.DataSource = this.dstPLog1;
            // 
            // dstPLog1
            // 
            this.dstPLog1.DataSetName = "dstPLog";
            this.dstPLog1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuClose,
            this.vacCalcToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(584, 24);
            this.mnuMain.TabIndex = 1;
            this.mnuMain.Text = "menuStrip1";
            // 
            // mnuClose
            // 
            this.mnuClose.Name = "mnuClose";
            this.mnuClose.Size = new System.Drawing.Size(48, 20);
            this.mnuClose.Text = "Close";
            this.mnuClose.Click += new System.EventHandler(this.mnuClose_Click);
            // 
            // vacCalcToolStripMenuItem
            // 
            this.vacCalcToolStripMenuItem.Name = "vacCalcToolStripMenuItem";
            this.vacCalcToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.vacCalcToolStripMenuItem.Text = "Vac Calc";
            this.vacCalcToolStripMenuItem.Click += new System.EventHandler(this.vacCalcToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(70, 58);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(100, 20);
            this.txtFilter.TabIndex = 14;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Name Filter";
            // 
            // btnClearFilter
            // 
            this.btnClearFilter.Location = new System.Drawing.Point(176, 56);
            this.btnClearFilter.Name = "btnClearFilter";
            this.btnClearFilter.Size = new System.Drawing.Size(75, 23);
            this.btnClearFilter.TabIndex = 16;
            this.btnClearFilter.Text = "Clear";
            this.btnClearFilter.UseVisualStyleBackColor = true;
            this.btnClearFilter.Visible = false;
            this.btnClearFilter.Click += new System.EventHandler(this.btnClearFilter_Click);
            // 
            // btnDayAdd
            // 
            this.btnDayAdd.Location = new System.Drawing.Point(534, 53);
            this.btnDayAdd.Name = "btnDayAdd";
            this.btnDayAdd.Size = new System.Drawing.Size(40, 22);
            this.btnDayAdd.TabIndex = 17;
            this.btnDayAdd.TabStop = false;
            this.btnDayAdd.Text = ">";
            this.btnDayAdd.UseVisualStyleBackColor = true;
            this.btnDayAdd.Click += new System.EventHandler(this.btnDayAdd_Click);
            // 
            // btnDaySubtract
            // 
            this.btnDaySubtract.Location = new System.Drawing.Point(292, 53);
            this.btnDaySubtract.Name = "btnDaySubtract";
            this.btnDaySubtract.Size = new System.Drawing.Size(40, 22);
            this.btnDaySubtract.TabIndex = 18;
            this.btnDaySubtract.TabStop = false;
            this.btnDaySubtract.Text = "<";
            this.btnDaySubtract.UseVisualStyleBackColor = true;
            this.btnDaySubtract.Click += new System.EventHandler(this.btnDaySubtract_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 512);
            this.Controls.Add(this.btnDaySubtract);
            this.Controls.Add(this.btnDayAdd);
            this.Controls.Add(this.btnClearFilter);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.bntSave);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.txtDestination);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtTimeOut);
            this.Controls.Add(this.txtReturnTime);
            this.Controls.Add(this.dateTimePLog);
            this.Controls.Add(this.dgvPLog);
            this.Controls.Add(this.mnuMain);
            this.MainMenuStrip = this.mnuMain;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LAFP Personal Log";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dstPLog1)).EndInit();
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPLog;
        private System.Windows.Forms.DateTimePicker dateTimePLog;
        private System.Windows.Forms.TextBox txtReturnTime;
        private System.Windows.Forms.TextBox txtTimeOut;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button bntSave;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private dstPLog dstPLog1;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand2;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand2;
        private System.Data.OleDb.OleDbDataAdapter daPLog;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand;
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuClose;
        private System.Windows.Forms.ToolStripMenuItem vacCalcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.BindingSource bsPLog;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnClearFilter;
        private System.Data.OleDb.OleDbConnection cntPLog;
        private System.Windows.Forms.Button btnDayAdd;
        private System.Windows.Forms.Button btnDaySubtract;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeOutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn returnTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn InputDate;
    }
}

