using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTrackingSystem.com.bugtracking.Controller
{
    class AdminController
    {
        private ConnectionController connectionController;
        
        public AdminController() {
            connectionController = new ConnectionController();
        }

        public int insertUser(string email)
        {
            string query = "insert into people(name) values('" + email + "')";
            int result = 0;

            if (ConnectionController.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, ConnectionController.connection);

                result = cmd.ExecuteNonQuery();

                ConnectionController.CloseConnection();
                return result;
            }
            return result;
        }

        public int addProject(string projectName, DateTime startDate, DateTime endDate, string projectDesc)
        {
            int result = 0;
            string query = "insert into project(project_name, start_date, end_date, project_desc) " +
                "VALUES('"+projectName+"', '"+startDate+"', '"+endDate+"', '"+projectDesc+"')";

            if (ConnectionController.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, ConnectionController.connection);

                result = cmd.ExecuteNonQuery();

                ConnectionController.CloseConnection();

                return result;
            }
            return result;
        }
    }
}
