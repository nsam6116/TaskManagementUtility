using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagementApp.Entities
{
    public interface ITask
    {
         int TaskID { get; set; }
         string TaskName { get; set; }
         string TaskDesc { get; set; }
         DateTime DueDate { get; set; }
         //string DueStatus { get; set; }
         //string CompletionStatus { get; set; }
    }
}
