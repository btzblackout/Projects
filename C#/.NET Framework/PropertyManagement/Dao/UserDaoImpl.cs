using PropertyManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyManagement.Dao
{
    class UserDaoImpl : UserDao
    {
        List<User> userList = new List<User>();

        // Register a new User.
        public bool RegisterUser(User user)
        {
            userList.Add(new User(user.UserID, user.Username, user.Password));
            return true;
        }

        // Check if a User exists by their username.
        public bool UserExists(string username)
        {
            userList.Add(new User(0, "admin", "admin"));
            bool exists = false;
            foreach (User user in userList)
            {
                if(user.Username == username)
                {
                    exists = true;
                }
            }
            return exists;
        }

        // Login a User.
        public User Login(string username, string password)
        {

            User returnUser = new User();
            // Check if the user is in the database.
            foreach (User user in userList)
            {
                if(user.Username == username && user.Password == password)
                {
                    returnUser = user;
                }
            }

            return returnUser;
        }

        // Update a User.
        public bool UpdateUser(User user)
        {
            throw new NotImplementedException();
        }

        // Delete a User.
        public bool DeleteUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
