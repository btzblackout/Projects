using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyManagement.Models
{
    public class User
    {
        // Declare variables /w Getters & Setters.

        // The users ID
        private int userID;
        public int UserID
        {
            get { return userID; }
            set { userID = value; }
        }

        // The users username.
        private string username;
        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        // The users password.
        private string password;
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        // Constructors

        public User()
        {

        }
        public User(int userID, string username, string password)
        {
            this.userID = userID;
            this.username = username;
            this.password = password;
        }

    }
}
