using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTrackingSystem.com.bugtracking.Controller
{
    class UserController
    {
        private ConnectionController connectionController;
        private MySqlDataAdapter sqlDa;
        public UserController()
        {
            connectionController = new ConnectionController();
        }

        public DataTable retriveProject()
        {
            DataTable dataTable = new DataTable();
            string query = "select * from people";

            /*if (ConnectionController.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, ConnectionController.connection);

                result = cmd.ExecuteNonQuery();

                ConnectionController.CloseConnection();
                return result;
            }
            return result;*/

            sqlDa = new MySqlDataAdapter(query, ConnectionController.connection);
            sqlDa.Fill(dataTable);

            return dataTable;
        }
    }
}
