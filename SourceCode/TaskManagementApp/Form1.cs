using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using TaskManagementApp.Entities;
using TaskManagementApp.Presenter;
using TaskManagementApp.View;

namespace TaskManagementApp
{
    public partial class Form1 : Form, IView
    {
        public DataTable dt;
        private const int pageSize = 5;

        public Form1()
        {
            InitializeComponent();
            var presenter = new TaskMgmPresenter(this);
            refreshdataGrid();
        }

        #region Private Attributes
        bool blnUpdateMode, isCompleted = false;

        #endregion

        #region MyRegion

        public int iTaskID
        {
            get
            {
                return int.Parse(txtTaskID.Text);
            }
        }

        string IView.TaskName
        {
            get
            {
                return txtName.Text;
            }
        }

        public string TaskDesc
        {
            get
            {
                return rtxtDesc.Text;
            }

        }

        public DateTime DueDate
        {
            get
            {
                return Convert.ToDateTime(dtTaskDueDate.Text);
            }
        }

        public TaskMgmPresenter Presenter { private get; set; }
        #endregion


        private void Form1_Load(object sender, EventArgs e)
        {

            refreshdataGrid();
        }

        private void refreshdataGrid()
        {
            dt = Presenter.GetAllTasks();
            var pageOffsets = new List<int>();
            for (int offset = 0; offset < dt.Rows.Count; offset += pageSize)
                pageOffsets.Add(offset);

            if (dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
            }
        }


        #region Private Methods
        private void ShowPastDueStatus()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (Convert.ToDateTime(row.Cells["TaskDueDate"].Value) < DateTime.Now)
                {
                    row.Cells["TaskStatus"].Value = "Past Due";




                    foreach (DataGridViewColumn c in dataGridView1.Columns)
                    {
                        c.DefaultCellStyle.Font = new Font("Arial", 8.5F, GraphicsUnit.Pixel);
                    }
                }
            }
        }

        private void DeleteRowForTaskID()
        {
            Presenter.DeleteTask();
            refreshdataGrid();
        }

        #endregion

        #region DataGrid Events

        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            txtName.Text = row.Cells["TaskName"].Value.ToString();
            rtxtDesc.Text = row.Cells["TaskDescription"].Value.ToString();
            txtTaskID.Text = row.Cells["TaskID"].Value.ToString();
            dtTaskDueDate.Text = row.Cells["TaskDueDate"].Value.ToString();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["MarkCompleted"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                txtTaskID.Text = (row.Cells["TaskID"].Value.ToString());
                UpdateCompletedStatus();
                row.ReadOnly = true;
            }
            if (e.ColumnIndex == dataGridView1.Columns["UpdateRow"].Index && e.RowIndex >= 0)
            {
                groupBox1.Visible = true;
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                txtName.Text = row.Cells["TaskName"].Value.ToString();
                rtxtDesc.Text = row.Cells["TaskDescription"].Value.ToString();
                txtTaskID.Text = row.Cells["TaskID"].Value.ToString();
                blnUpdateMode = true;
            }
            if (e.ColumnIndex == dataGridView1.Columns["DeleteRow"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                txtTaskID.Text = row.Cells["TaskID"].Value.ToString();
                DeleteRowForTaskID();
            }
        }

        #endregion

        private void UpdateCompletedStatus()
        {
            Presenter.UpdateCompleted();
            refreshdataGrid();
        }

        /// <summary>
        /// Validation Method for TaskNAme and DueDate
        /// </summary>
        private void ValidateInput()
        {
            try
            {
            if (txtName.Text == string.Empty)
            {
                MessageBox.Show("Please enter a valid Task Name", "Missing Field", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }

            if (dtTaskDueDate.Text == string.Empty)
            {
                MessageBox.Show("Please select a valid Due Date", "Missing Field", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);

            }
            }
            catch (Exception)
            {

                throw;
            }
        }

        #region Button Events

        /// <summary>
        /// Reset Controls
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnReset_Click(object sender, EventArgs e)
        {
            txtName.Text = string.Empty;
            groupBox1.Visible = false;
        }

        /// <summary>
        /// Save button Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSave_Click(object sender, EventArgs e)
        {
            ValidateInput();

            if (blnUpdateMode == true)
            {
                Presenter.UpdateTask(iTaskID);
            }
            else
            {
                Presenter.AddNewTask();
            }

            refreshdataGrid();
            groupBox1.Visible = false;

            Presenter.GetAllTasks();
        }

        /// <summary>
        /// Exit Application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Create New Task
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAdd_Click(object sender, EventArgs e)
        {

            groupBox1.Visible = true;
            pnlSaveReset.Visible = true;

        }
        #endregion

    }
}

