using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BugTrackingSystem.com.bugtracking.Controller
{
    
    class LoginController
    {
        private ConnectionController connectionController;

        public LoginController()
        {
            connectionController = new ConnectionController();
        }

        public int SelectUser(string email, string password)
        {
            int u_id = 0;

            String query = "Select * from user where email = '"+email+"' and password = '"+password+"'";

            if (ConnectionController.OpenConnection() == true)
            {
                MySqlCommand command = new MySqlCommand(query, ConnectionController.connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    u_id = (int) reader["user_id"];
                }
            }
            ConnectionController.CloseConnection();

            return u_id;
        }

        //Insert statement
        public void Insert()
        {
            string query = "INSERT INTO bugs (bug_desc, bug_pic, project_id, user_id) VALUES ('')";

            if (ConnectionController.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, ConnectionController.connection);

                cmd.ExecuteNonQuery();

                ConnectionController.CloseConnection();
            }

        }

        //Update statement
        public void Update()
        {
        }

        //Delete statement
        public void Delete()
        {
        }

        //Select statement
        /*public List<string>[] Select()
        {
        }

        //Count statement
        public int Count()
        {
        }*/

        //Backup
        public void Backup()
        {
        }

        //Restore
        public void Restore()
        {
        }
    }
}
