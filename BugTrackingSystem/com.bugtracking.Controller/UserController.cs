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
        private MySqlCommand command;

        public UserController()
        {
            connectionController = new ConnectionController();
        }

        public DataTable retriveProject()
        {
            DataTable dataTable = new DataTable();
            string query = "select * from bugs";

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
               
        public int insertBug(String bug_desc, byte[] image, string state, string severity, int project_id, int user_id)
        {
            int result = 0;
            String query = "insert into bugs(bug_desc, bug_pic, state, severity, project_id, user_id) " +
                "values(@desc, @pic, @state, @severity, @project, @user)";

            command = new MySqlCommand(query, ConnectionController.connection);

            command.Parameters.Add("@desc", MySqlDbType.Text);
            command.Parameters.Add("@pic", MySqlDbType.Blob);
            command.Parameters.Add("@state", MySqlDbType.VarChar, 15);
            command.Parameters.Add("@severity", MySqlDbType.VarChar, 20);
            command.Parameters.Add("@project", MySqlDbType.Int32);
            command.Parameters.Add("@user", MySqlDbType.Int32);

            command.Parameters["@desc"].Value = bug_desc;
            command.Parameters["@pic"].Value = image;
            command.Parameters["@state"].Value = state;
            command.Parameters["@severity"].Value = severity;
            command.Parameters["@project"].Value = project_id;
            command.Parameters["@user"].Value = user_id;

            result = command.ExecuteNonQuery();

            return result;
        }
    }
}
