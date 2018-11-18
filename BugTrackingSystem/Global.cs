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

        public static int User_id {
            get => user_id;
            set => user_id = value;
        }
    }
}
