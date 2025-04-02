using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Financial_Management_App.DataAccess;
using Financial_Management_App.Models;
using System.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;

namespace Financial_Management_App.Controllers
{
    public class LoginController : Controller
    {
        private readonly UserDao userDAO;

        public LoginController(IConfiguration configuration)
        {
            userDAO = new UserDaoImp(configuration);
        }

        // Landing (Login) page.
        public IActionResult Index()
        {
            // Check for user session, if one exists then redirect to home page.
            string user = HttpContext.Session.GetString("username");
            if (user != null)
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
            try
            {
                // Check the users credentials.
                User newUser = userDAO.Login(user);

                // If the username returned is null the credentials were invalid.
                if (newUser.Username != null)
                {
                    HttpContext.Session.SetString("username", newUser.Username);
                    return RedirectToAction("Index", "Home");
                }

                return View("LoginError");
            }
            catch (Exception ex)
            {

                return Content($"Login failed: {ex.Message}");
            }
        }

        public IActionResult Register(User user)
        {
            try
            {
                if (ModelState.IsValid && user.Username != null)
                {
                    User checkUsername = userDAO.CheckByUsername(user.Username);
                    if (checkUsername.Username == null)
                    {
                        userDAO.Register(user);
                        return View("Index");
                    }
                    return View("RegisterExists", user);
                }
                return View();
            }
            catch (Exception ex)
            {
                return Content($"Register failed: {ex.Message}");
            }
        }
    }
}
