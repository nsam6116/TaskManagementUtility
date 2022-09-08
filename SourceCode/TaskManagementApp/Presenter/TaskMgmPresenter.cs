using System.Data;
using TaskManagementApp.Entities;
using TaskManagementApp.Model;
using TaskManagementApp.View;

namespace TaskManagementApp.Presenter
{
    public class TaskMgmPresenter
    {

        IView _view;
        ITaskMgmModel _model;

        public TaskMgmPresenter(IView view)
        {
            _view = view;
            view.Presenter = this;
            _model = new TaskMgmModel();
        }

        public void UpdateTask(int taskid)
        {
            ETask Task = new ETask();
            string d = _view.TaskName;
             Task.TaskName = _view.TaskName;
            Task.TaskDesc = _view.TaskDesc ;
            _model.UpdateTask(taskid, Task);
        }

        public DataTable GetAllTasks()
       {
            return _model.GetAllTasks();
       }

        public void DeleteTask()
        {
            _model.DeleteTask(_view.iTaskID);
        }

        public void AddNewTask()
        {
            ETask Task = new ETask { TaskName = _view.TaskName, TaskDesc = _view.TaskDesc };
           _model.AddNewTask(Task);
        }

        public void UpdateCompleted()
        {
            _model.UpdateCompleted(_view.iTaskID);
        }
    }
}
