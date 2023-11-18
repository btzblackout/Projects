using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Financial_Management_App.Models;

namespace Financial_Management_App.DataAccess
{
    public interface UserDao
    {
        // Create
        public void Register(User user);

        // Read
        public User Login(User user);
        public User CheckByUsername(string username);

        // Update
        public void UpdateBalance(int id, Decimal balance, User user);     
    }
}
