using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PropertyManagement.Models;

namespace PropertyManagement.Dao
{
    interface UserDao
    {
        
        //              Create
        // Register a new User.
        Boolean RegisterUser(User user);

        //              Read
        // Check if a User exists by their username.
        Boolean UserExists(string username);
        // Login a User.
        User Login(string username, string password);

        //              Update
        // Update a Users information.
        Boolean UpdateUser(User user);

        //              Delete
        // Delete a User.
        Boolean DeleteUser(User user);
    }
}
