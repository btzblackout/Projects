using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPCoreFirstApp.Services;

namespace ASPCoreFirstApp.Controllers
{
    public class VideoGameController : Controller
    {
        public IActionResult Index()
        {
            VideoGameDatabaseClass repository = new VideoGameDatabaseClass();
            return View(repository.AllVideoGames());
        }
    }
}
