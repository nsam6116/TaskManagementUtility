using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagementApp.Entities;

namespace TaskManagementApp.View
{
    public interface IView
    {
        int iTaskID { get;  }
        string TaskName { get;  }
        string TaskDesc { get; }
        
        DateTime DueDate { get; }

        Presenter.TaskMgmPresenter Presenter { set; }

   }
}
