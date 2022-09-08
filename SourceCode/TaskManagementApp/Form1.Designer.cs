namespace TaskManagementApp
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblGridHeader = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnlSaveReset = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rtxtDesc = new System.Windows.Forms.RichTextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.dtTaskDueDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTaskID = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.TaskID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaskName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaskDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaskDueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaskIsEligible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DueStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaskStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MarkCompleted = new System.Windows.Forms.DataGridViewButtonColumn();
            this.UpdateRow = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteRow = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.pnlSaveReset.SuspendLayout();
            this.panel1.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TaskID,
            this.TaskName,
            this.TaskDescription,
            this.TaskDueDate,
            this.TaskIsEligible,
            this.DueStatus,
            this.TaskStatus,
            this.MarkCompleted,
            this.UpdateRow,
            this.DeleteRow});
            this.dataGridView1.Location = new System.Drawing.Point(12, 93);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1454, 355);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellDoubleClick);
            this.dataGridView1.BindingContextChanged += new System.EventHandler(this.Form1_Load);
            // 
            // lblGridHeader
            // 
            this.lblGridHeader.AutoSize = true;
            this.lblGridHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGridHeader.Location = new System.Drawing.Point(589, 13);
            this.lblGridHeader.Name = "lblGridHeader";
            this.lblGridHeader.Size = new System.Drawing.Size(297, 29);
            this.lblGridHeader.TabIndex = 1;
            this.lblGridHeader.Text = "Task Management System";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 52);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(302, 35);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add New Task";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(639, 6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pnlSaveReset);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.rtxtDesc);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.dtTaskDueDate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 454);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1454, 157);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create New Task";
            this.groupBox1.Visible = false;
            // 
            // pnlSaveReset
            // 
            this.pnlSaveReset.Controls.Add(this.btnSave);
            this.pnlSaveReset.Controls.Add(this.btnReset);
            this.pnlSaveReset.Location = new System.Drawing.Point(485, 118);
            this.pnlSaveReset.Name = "pnlSaveReset";
            this.pnlSaveReset.Size = new System.Drawing.Size(358, 33);
            this.pnlSaveReset.TabIndex = 15;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(61, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(204, 5);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 14;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(1311, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(315, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "*";
            // 
            // rtxtDesc
            // 
            this.rtxtDesc.Location = new System.Drawing.Point(543, 11);
            this.rtxtDesc.Name = "rtxtDesc";
            this.rtxtDesc.Size = new System.Drawing.Size(257, 68);
            this.rtxtDesc.TabIndex = 7;
            this.rtxtDesc.Text = "";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(109, 21);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 22);
            this.txtName.TabIndex = 5;
            // 
            // dtTaskDueDate
            // 
            this.dtTaskDueDate.Location = new System.Drawing.Point(1105, 21);
            this.dtTaskDueDate.MinDate = new System.DateTime(2022, 9, 6, 0, 0, 0, 0);
            this.dtTaskDueDate.Name = "dtTaskDueDate";
            this.dtTaskDueDate.Size = new System.Drawing.Size(200, 22);
            this.dtTaskDueDate.TabIndex = 4;
            this.dtTaskDueDate.Value = new System.DateTime(2022, 9, 6, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(996, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Task Due Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(439, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Task Name";
            // 
            // txtTaskID
            // 
            this.txtTaskID.Location = new System.Drawing.Point(3, 0);
            this.txtTaskID.Name = "txtTaskID";
            this.txtTaskID.Size = new System.Drawing.Size(23, 22);
            this.txtTaskID.TabIndex = 12;
            this.txtTaskID.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.txtTaskID);
            this.panel1.Location = new System.Drawing.Point(12, 627);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1454, 32);
            this.panel1.TabIndex = 13;
            // 
            // toolStripContainer1
            // 
            this.toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.AutoScroll = true;
            this.toolStripContainer1.ContentPanel.Controls.Add(this.panel1);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.groupBox1);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.lblGridHeader);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.btnAdd);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.dataGridView1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(1478, 664);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(1478, 664);
            this.toolStripContainer1.TabIndex = 15;
            this.toolStripContainer1.Text = "toolStripContainer1";
            this.toolStripContainer1.TopToolStripPanelVisible = false;
            // 
            // TaskID
            // 
            this.TaskID.DataPropertyName = "TaskID";
            this.TaskID.HeaderText = "Task ID";
            this.TaskID.Name = "TaskID";
            this.TaskID.ReadOnly = true;
            this.TaskID.Width = 50;
            // 
            // TaskName
            // 
            this.TaskName.DataPropertyName = "TaskName";
            this.TaskName.HeaderText = "Name";
            this.TaskName.Name = "TaskName";
            this.TaskName.ReadOnly = true;
            // 
            // TaskDescription
            // 
            this.TaskDescription.DataPropertyName = "TaskDescription";
            this.TaskDescription.HeaderText = "Task Description";
            this.TaskDescription.MinimumWidth = 50;
            this.TaskDescription.Name = "TaskDescription";
            this.TaskDescription.ReadOnly = true;
            this.TaskDescription.Width = 250;
            // 
            // TaskDueDate
            // 
            this.TaskDueDate.DataPropertyName = "TaskDueDate";
            this.TaskDueDate.HeaderText = "Task Due Date";
            this.TaskDueDate.Name = "TaskDueDate";
            this.TaskDueDate.ReadOnly = true;
            this.TaskDueDate.Width = 120;
            // 
            // TaskIsEligible
            // 
            this.TaskIsEligible.DataPropertyName = "TaskIsUpdatable";
            this.TaskIsEligible.HeaderText = "Task Can Update";
            this.TaskIsEligible.Name = "TaskIsEligible";
            this.TaskIsEligible.ReadOnly = true;
            this.TaskIsEligible.Visible = false;
            // 
            // DueStatus
            // 
            dataGridViewCellStyle4.Format = "F";
            dataGridViewCellStyle4.NullValue = null;
            this.DueStatus.DefaultCellStyle = dataGridViewCellStyle4;
            this.DueStatus.HeaderText = "Due Status";
            this.DueStatus.Name = "DueStatus";
            this.DueStatus.ReadOnly = true;
            this.DueStatus.Visible = false;
            this.DueStatus.Width = 50;
            // 
            // TaskStatus
            // 
            this.TaskStatus.DataPropertyName = "TaskStatus";
            this.TaskStatus.HeaderText = "TaskStatus";
            this.TaskStatus.Name = "TaskStatus";
            this.TaskStatus.ReadOnly = true;
            // 
            // MarkCompleted
            // 
            this.MarkCompleted.DataPropertyName = "MarkCompleted";
            this.MarkCompleted.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.MarkCompleted.HeaderText = "Update Status ";
            this.MarkCompleted.Name = "MarkCompleted";
            this.MarkCompleted.ReadOnly = true;
            this.MarkCompleted.Text = "Mark Complete";
            this.MarkCompleted.ToolTipText = "Mark Complete";
            this.MarkCompleted.UseColumnTextForButtonValue = true;
            // 
            // UpdateRow
            // 
            this.UpdateRow.HeaderText = "Update Row";
            this.UpdateRow.Name = "UpdateRow";
            this.UpdateRow.ReadOnly = true;
            this.UpdateRow.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.UpdateRow.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.UpdateRow.Text = "Update";
            this.UpdateRow.UseColumnTextForButtonValue = true;
            // 
            // DeleteRow
            // 
            this.DeleteRow.HeaderText = "DeleteRow";
            this.DeleteRow.Name = "DeleteRow";
            this.DeleteRow.ReadOnly = true;
            this.DeleteRow.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DeleteRow.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.DeleteRow.Text = "Delete";
            this.DeleteRow.UseColumnTextForButtonValue = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1478, 664);
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "Form1";
            this.Text = "Dashboard Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlSaveReset.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblGridHeader;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rtxtDesc;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DateTimePicker dtTaskDueDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTaskID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlSaveReset;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskDueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskIsEligible;
        private System.Windows.Forms.DataGridViewTextBoxColumn DueStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskStatus;
        private System.Windows.Forms.DataGridViewButtonColumn MarkCompleted;
        private System.Windows.Forms.DataGridViewButtonColumn UpdateRow;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteRow;
    }
}

