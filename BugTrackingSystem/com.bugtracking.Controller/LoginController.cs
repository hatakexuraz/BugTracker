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

        public string[] SelectUser(string email, string password, string type)
        {
            String[] user = new string[4];

            String query = "Select * from user where email = '"+email+"' and password = '"+password+"' and type = '"+type+"'";

            if (ConnectionController.OpenConnection() == true)
            {
                MySqlCommand command = new MySqlCommand(query, ConnectionController.connection);
                MySqlDataReader reader = command.ExecuteReader();


                while(reader.Read())
                {
                    user[0] = reader.GetInt32("user_id").ToString();
                    user[1] = reader.GetString("email");
                    user[2] = reader.GetString("password");
                    user[3] = reader.GetString("type");
                }
            }
            ConnectionController.CloseConnection();
            
            return user;
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
