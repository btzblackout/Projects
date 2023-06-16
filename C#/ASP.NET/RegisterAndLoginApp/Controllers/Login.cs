using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RegisterAndLoginApp.Models;
using RegisterAndLoginApp.Services;
using RegisterAndLoginApp.Utility;
using Microsoft.AspNetCore.Http;

namespace RegisterAndLoginApp.Controllers
{
    public class Login : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [LogActionFilter]
        public IActionResult ProcessLogin(UserModel user)
        {

            SecurityService securityService = new SecurityService();
            
            if(user.Username == "admin")
            {
                System.Diagnostics.Debugger.Break();
            }

            if (securityService.IsValid(user))
            {
                // remember who is logged in
                HttpContext.Session.SetString("username", user.Username);
                return View("LoginSuccess", user);
            }
            else
            {
                // cancel any existing valid login
                HttpContext.Session.Remove("username");
                return View("LoginFailure", user);
            }
        }
        [HttpGet]
        [CustomAuthorization]
        public IActionResult PrivateSectionMustBeLoggedIn()
        {
            return Content("I am a protected method if the proper attribute is applied to me.");
        }
    }
}
