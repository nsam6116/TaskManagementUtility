using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagementApp.Entities
{
    public class ETask : ITask
    {
        public int TaskID { get; set; }
        public string TaskName { get; set; }

        public string TaskDesc { get; set; }

        public DateTime DueDate { get; set; }


    }
}
