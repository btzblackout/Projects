using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AJAXExample.Models;

namespace AJAXExample.Controllers
{
    public class CustomerController : Controller
    {
        List<CustomerModel> customers = new List<CustomerModel>();
        public CustomerController()
        {
            customers.Add(new CustomerModel(0, "Sherry", 42));
            customers.Add(new CustomerModel(1, "Melvin", 18));
            customers.Add(new CustomerModel(2, "Jerry", 26));
            customers.Add(new CustomerModel(3, "Velma", 34));
            customers.Add(new CustomerModel(4, "Wendy", 7));
            customers.Add(new CustomerModel(5, "Kim", 82));

        }
        public IActionResult Index()
        {
            return View(customers);
        }

        //On the form, the radio buttons have the property name="Id" and id="Id" so the value of the radio button is passed as the Id property.
        public IActionResult ShowOnePerson(int Id)
        {
            
            return PartialView(customers.FirstOrDefault(c => c.Id == Id));
        }
    }
}
