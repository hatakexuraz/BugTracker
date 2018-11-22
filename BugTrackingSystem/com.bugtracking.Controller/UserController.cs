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

        public DataTable retriveBugs()
        {
            DataTable dataTable = new DataTable();
            string query = "select * from bugs where user_id = '"+Global.User_id+"' ";
            
            command = new MySqlCommand(query, ConnectionController.connection);
            sqlDa = new MySqlDataAdapter(command);

            sqlDa.Fill(dataTable);

            return dataTable;
        }
               
        public int insertBug(String bug_title, String source_code, byte[] image, string state, string severity, int line_no, string method_name, 
            String class_name, int user_id)
        {
            int result = 0;
            String query = "insert into bugs(bug_title, source_code, bug_pic, state, severity, line_no, method_name, class_name, user_id) " +
                "values(@bug_title, @code, @pic, @state, @severity, @line_no, @method_name, @class_name, @user)";

            ConnectionController.OpenConnection();
            command = new MySqlCommand(query, ConnectionController.connection);

            command.Parameters.Add("@bug_title", MySqlDbType.VarChar, 20);
            command.Parameters.Add("@code", MySqlDbType.LongText);
            command.Parameters.Add("@pic", MySqlDbType.Blob);
            command.Parameters.Add("@state", MySqlDbType.VarChar, 15);
            command.Parameters.Add("@severity", MySqlDbType.VarChar, 20);
            command.Parameters.Add("@line_no", MySqlDbType.Int32);
            command.Parameters.Add("@method_name", MySqlDbType.VarChar, 20);
            command.Parameters.Add("@class_name", MySqlDbType.VarChar, 20);
            command.Parameters.Add("@user", MySqlDbType.Int32);

            command.Parameters["@bug_title"].Value = bug_title;
            command.Parameters["@code"].Value = source_code;
            command.Parameters["@pic"].Value = image;
            command.Parameters["@state"].Value = state;
            command.Parameters["@severity"].Value = severity;
            command.Parameters["@line_no"].Value = line_no;
            command.Parameters["@method_name"].Value = method_name;
            command.Parameters["@class_name"].Value = class_name;
            command.Parameters["@user"].Value = user_id;

            result = command.ExecuteNonQuery();

            return result;
        }
    }
}
