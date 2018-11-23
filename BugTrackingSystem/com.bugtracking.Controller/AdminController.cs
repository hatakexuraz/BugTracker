using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTrackingSystem.com.bugtracking.Controller
{
    class AdminController
    {
        private ConnectionController connectionController;
        private MySqlDataAdapter sqlDa;

        public AdminController() {
            connectionController = new ConnectionController();
        }

        public int insertUser(string email, string password, string type)
        {
            string query = "insert into user(email, password, type) values('" + email + "', '"+password+"', '"+type+"')";
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

        public DataTable retriveUser()
        {
            DataTable dataTable = new DataTable();
            string query = "select * from user";
            
            sqlDa = new MySqlDataAdapter(query, ConnectionController.connection);
            sqlDa.Fill(dataTable);

            return dataTable;
        }

        public int addProject(string projectName, String startDate, String endDate, string projectDesc)
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

        public DataTable retriveProjects()
        {
            DataTable dataTable = new DataTable();
            string query = "select * from project";

            MySqlCommand command = new MySqlCommand(query, ConnectionController.connection);
            sqlDa = new MySqlDataAdapter(command);

            sqlDa.Fill(dataTable);

            return dataTable;
        }
    }
}
