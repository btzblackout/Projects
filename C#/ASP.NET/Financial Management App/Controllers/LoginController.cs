using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Financial_Management_App.DataAccess;
using Financial_Management_App.Models;
using System.Diagnostics;
using Microsoft.AspNetCore.Http;

namespace Financial_Management_App.Controllers
{
    public class LoginController : Controller
    {
        UserDao userDAO = new UserDaoImp();

        // Landing (Login) page.
        public IActionResult Index()
        {
            // Check for user session, if one exists then redirect to home page.
            string user = HttpContext.Session.GetString("username");
            if(user != null)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View();
            }

        }

        // Login method.
        public IActionResult Login(User user)
        {
            User newUser = new User();
            
            // Check the users credentials.
            newUser = userDAO.Login(user);

            // If the username returned is null the credentials were invalid.
            if (newUser.Username != null)
            {
                HttpContext.Session.SetString("username", newUser.Username);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View("LoginError");
            }
        }

        public IActionResult Register(User user)
        {
            if (ModelState.IsValid)
            {
                // This is from the Register page, attempt to register the user.
                if (user.Username != null)
                {
                    // Check if the username already exists.
                    User checkUsername = userDAO.CheckByUsername(user.Username);

                    // If this == null then the username does not exist.
                    if (checkUsername.Username == null)
                    {
                        // Register the user
                        userDAO.Register(user);
                        return View("Index");
                    }

                    // Return the Register Error page.
                    return View("RegisterExists", user);
                }
            }
            // If user.Username == null the Register button was clicked on login page, return Register page.
            return View();
        }

        
    }
}
