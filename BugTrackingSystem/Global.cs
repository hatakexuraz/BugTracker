using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTrackingSystem
{
    static class Global
    {
        private static int user_id;
        private static string email;
        private static string type;

        public static int User_id {
            get => user_id;
            set => user_id = value;
        }
        public static string Email {
            get => email;
            set => email = value;
        }
        public static string Type {
            get => type;
            set => type = value;
        }
    }
}
