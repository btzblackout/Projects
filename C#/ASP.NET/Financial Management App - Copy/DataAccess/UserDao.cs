using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Financial_Management_App.Models;

namespace Financial_Management_App.DataAccess
{
    public interface UserDao
    {
        public User CheckByUsername(string username);
        public User Login(User user);
        public void Register(User user);
    }
}
