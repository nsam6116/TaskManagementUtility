using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagementApp.Model;

namespace TaskManagementApp.DAL
{
    public class DataLayer
    {
        private string _connectionString;

        enum RequestType
        {
            Add,
            Update,
            Delete,
            Read,
            ConfirmDelete
        }

        public DataLayer(string connectionString)
        {
           // _connectionString = connectionString;
        }

        static void GetConnectionStrings()
        {
            ConnectionStringSettingsCollection settings =
                ConfigurationManager.ConnectionStrings;

            if (settings != null)
            {
                foreach (ConnectionStringSettings cs in settings)
                {
                    Console.WriteLine(cs.Name);
                    Console.WriteLine(cs.ProviderName);
                    Console.WriteLine(cs.ConnectionString);
                }
            }
        }

        //public IEnumerable<ITaskMgmModel> GetAll()
        //{
        //    List<TaskMgmModel> TaskMgmList = new List<TaskMgmModel>();
        //    DataLayer dataAccess = new DataLayer(_connectionString);
        //}



    }
}
