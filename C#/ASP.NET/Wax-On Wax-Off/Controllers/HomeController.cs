using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MySql.Data.MySqlClient;
using Wax_On_Wax_Off.Models;

namespace Wax_On_Wax_Off.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            // Connect to Mysql.
            using (MySqlConnection con = new MySqlConnection("server=localhost;user=root;database=wax-on_wax-off;port=3306;password=root"))
            {
                MySqlCommand cmd = new MySqlCommand("select * from users", con);
                MySqlDataReader reader = cmd.ExecuteReader();

                while(reader.Read())
                {
                    //Extract your data.
                }
            }
                return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
