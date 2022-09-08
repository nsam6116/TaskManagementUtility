using System;
using System.Data;
using System.Data.SqlClient;
using TaskManagementApp.Entities;

namespace TaskManagementApp.Model
{
    public class TaskMgmModel : ITaskMgmModel
    {
        /// <summary>
        /// Delete a Task based on TaskID
        /// </summary>
        /// <param name="taskid"></param>
        public void DeleteTask(int taskid)
        {
            SqlConnection con = new SqlConnection(@"Data Source=nehaa\SQLExpress;Initial Catalog = TaskManagement; Integrated Security = True");
            SqlCommand cmd = new SqlCommand("DELETE FROM[dbo].[tblTaskManager]  where TaskID =" + taskid, con);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        /// <summary>
        /// Fetch all tasks
        /// </summary>
        /// <returns></returns>
        public DataTable GetAllTasks()
        {
            SqlConnection con = new SqlConnection(@"Data Source=nehaa\SQLExpress;Initial Catalog = TaskManagement; Integrated Security = True");
            SqlCommand cmd = new SqlCommand("select * from tblTaskManager", con);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            return dt;
        }


        /// <summary>
        /// Update Task based on TaskID
        /// </summary>
        /// <param name="taskid"></param>
        /// <param name="task"></param>
        public void UpdateTask(int taskid, ETask task)
        {
            SqlConnection con = new SqlConnection(@"Data Source=nehaa\SQLExpress;Initial Catalog = TaskManagement; Integrated Security = True");
            SqlCommand cmd = new SqlCommand("UPDATE[dbo].[tblTaskManager] " +
                "SET [TaskName] = '" + task.TaskName + "',[TaskDescription] ='" + task.TaskDesc + "' where TaskID =" + taskid, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }


        /// <summary>
        /// Create new task
        /// </summary>
        /// <param name="task"></param>
        public void AddNewTask(ETask task)
        {
            SqlConnection con = new SqlConnection(@"Data Source=nehaa\SQLExpress;Initial Catalog = TaskManagement; Integrated Security = True");
            SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[tblTaskManager] " +
                "([TaskName],[TaskDescription],[TaskDueDate],[TaskStatus],[TaskIsUpdatable]) " +
                "VALUES ('" + task.TaskName + "','" + task.TaskDesc + "',GETDATE() ,'not due', 0)", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        /// <summary>
        /// Update Task Completed date based on selected TaskID (Row Selected)
        /// </summary>
        /// <param name="taskid"></param>
        public void UpdateCompleted(int taskid)
        {
            SqlConnection con = new SqlConnection(@"Data Source=nehaa\SQLExpress;Initial Catalog = TaskManagement; Integrated Security = True");
            SqlCommand cmd = new SqlCommand("UPDATE[dbo].[tblTaskManager] " +
             "SET [TaskStatus] = 'Completed',[TaskCompletedDate] ='" + DateTime.Now.ToString() + "' where TaskID =" + taskid, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

    }
}
