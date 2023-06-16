using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegisterAndLoginApp.Models
{
    public class UserModel
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string username;

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public override string ToString()
        {
            return "Username: " + Username + " Password: " + Password;
        }
    }
}
