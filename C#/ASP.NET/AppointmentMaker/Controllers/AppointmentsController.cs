using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppointmentMaker.Models;

namespace AppointmentMaker.Controllers
{
    public class AppointmentsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ShowAppointmentDetails(AppointmentModel model)
        {
            return View(model);
        }
    }
}
