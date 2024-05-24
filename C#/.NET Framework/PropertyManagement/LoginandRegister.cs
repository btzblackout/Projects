using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PropertyManagement.Models;
using PropertyManagement.Dao;
namespace PropertyManagement
{
    class LoginandRegister
    {
        UserDaoImpl userDao = new UserDaoImpl();
        
        // Login
        public User Login(string username, string password)
        {
            // Create a return user object.
            User returnUser = new User();
            
            // Call the Login method in the userDao object and pass the username and password provided.
            // Return the resulting User object.
            return returnUser = userDao.Login(username, password);
        }

        // Register
        public bool CheckIfUsernameExists(string username)
        {
            // Call the UserExists method in the userDao object and pass the username provided.
            // Return the resulting bool.
            return userDao.UserExists(username);
        }
        public bool Register(string username, string password)
        {
            // Create a new user object, populated with the provided username and password.
            User registeringUser = new User(0, username, password);
            
            // Call the RegisterUser method in the userDao object and pass the registeringUser object.
            // Return the resulting bool.
            return userDao.RegisterUser(registeringUser);
        }
    }
}
