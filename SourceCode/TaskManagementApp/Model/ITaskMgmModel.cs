using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagementApp.Entities;
using System.Data;

namespace TaskManagementApp.Model
{
    public interface ITaskMgmModel
    {
        DataTable GetAllTasks();
        void AddNewTask(ETask task);
        void DeleteTask(int taskid);
        void UpdateTask(int taskid, ETask task);

        void UpdateCompleted(int taskid);
    }
}
