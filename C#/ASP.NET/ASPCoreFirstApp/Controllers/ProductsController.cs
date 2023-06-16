using ASPCoreFirstApp.Models;
using Bogus;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using ASPCoreFirstApp.Services;
using NLog;

namespace ASPCoreFirstApp.Controllers
{
    public class ProductsController : Controller
    {
        private static Logger logger = LogManager.GetLogger("myAppLoggerRules");
        ProductsDAO repository = new ProductsDAO();

        public ProductsController()
        {
            repository = new ProductsDAO();
        }

        public IActionResult Index()
        {
            //Put an item in the log.
            logger.Info("Entering ProductsController: Index method.");
            return View(repository.AllProducts());
        }

        public IActionResult Message()
        {
            return View();
        }

        public IActionResult Welcome()
        {
            ViewBag.name = "Shad";
            ViewBag.secretNumber = 13;
            return View();
        }

        public IActionResult SearchResults(string searchTerm)
        {

            return View("Index", repository.SearchProducts(searchTerm));
        }

        public IActionResult SearchForm()
        {
            logger.Info("Inside the ProductsController. SearchForm method.");
            return View();
        }

        public IActionResult ShowOneProduct(int Id)
        {
            return View(repository.GetProductById(Id));
        }

        public IActionResult ShowEditForm(int Id)
        {
            return View(repository.GetProductById(Id));
        }

        public IActionResult ProcessEdit(ProductModel product)
        {
            repository.Update(product);
            return View("Index", repository.AllProducts());
        }

        public IActionResult ShowDelete(int Id)
        {
            if (repository.Delete(repository.GetProductById(Id)))
            {
                return View("Index", repository.AllProducts());
            }
            else
            {
                return View();
            }
        }

        public IActionResult ShowOneProductJSON(int Id)
        {
            return Json(repository.GetProductById(Id));
        }

        public IActionResult ProcessEditReturnPartial(ProductModel product)
        {
            repository.Update(product);
            return PartialView("_productCard", product);
        }
    }
}
