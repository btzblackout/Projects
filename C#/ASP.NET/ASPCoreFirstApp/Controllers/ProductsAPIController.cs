using ASPCoreFirstApp.Models;
using Bogus;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using ASPCoreFirstApp.Services;
using System.Web.Http.Description;

namespace ASPCoreFirstApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsAPIController : ControllerBase
    {
        ProductsDAO repository = new ProductsDAO();

        public ProductsAPIController()
        {
            repository = new ProductsDAO();
        }

        // No route specified since this is the default
        // /api/productsapi route.
        [HttpGet]
        [ResponseType(typeof(List<ProductDTO>))]
        public IEnumerable<ProductDTO> Index()
        {
            //get the products
            List<ProductModel> productList = repository.AllProducts();

            //translate into DTO
            IEnumerable<ProductDTO> productDTOList = from p in productList select new ProductDTO(p.Id, p.Name, p.Price, p.Description);
            
            return productDTOList;
        }

        [HttpGet("searchresults/{searchTerm}")]
        //GET /api/productsapi/searchresults/xyz
        public IEnumerable<ProductDTO> SearchResults(string searchTerm)
        {
            //get the list of ProductModel
            List<ProductModel> productList = repository.SearchProducts(searchTerm);

            //translate into DTO
            IEnumerable<ProductDTO> productDTOList = from p in productList select new ProductDTO(p.Id, p.Name, p.Price, p.Description);
            return productDTOList;
        }

        //Not used in a REST API. This method returns a data entry form
        //public IActionResult SearchForm()
        //{
        //   return View();
        //}

        [HttpGet("showoneproduct/{Id}")]
        [ResponseType(typeof(ProductDTO))]
        //GET /api/productsapi/showoneproduct/3
        public ActionResult <ProductDTO> ShowOneProduct(int Id)
        {
            //get the correct product from the database.
            ProductModel product = repository.GetProductById(Id);

            //create a new DTO based on the product
            ProductDTO productDTO = new ProductDTO(product.Id, product.Name, product.Price, product.Description);

            //return the DTO instead of the product
            return productDTO;
        }

        //Not used in a REST API. This method returns a data entry form
        //public IActionResult ShowEditForm(int Id)
        //{
        //    return View(repository.GetProductById(Id));
        //}

        [HttpPut("processedit")]
        [ResponseType(typeof(List<ProductDTO>))]
        //GET /api/productsapi/processedit/product
        public IEnumerable<ProductDTO> ProcessEdit(ProductModel product)
        {
            //update the product.
            repository.Update(product);

            //Create a list of the products.
            List<ProductModel> productList = repository.AllProducts();

            //Convert to DTO objects.
            IEnumerable<ProductDTO> productDTOList = from p in productList select new ProductDTO(p.Id, p.Name, p.Price, p.Description);

            return productDTOList;
        }
        
        [HttpPut("ProcessEditReturnOneItem")]
        [ResponseType(typeof(ProductDTO))]
        //GET /api/productsapi/processeditreturnoneitem/product
        public ActionResult <ProductDTO> ProcessEditReturnOneItem(ProductModel product)
        {
            //Update the product in the database.
            repository.Update(product);
            
            //Grab the product that was updated.
            ProductModel productReturned = repository.GetProductById(product.Id);
            
            //Conver the product to the DTO verson for sending to client.
            ProductDTO productDTO = new ProductDTO(productReturned.Id, productReturned.Name, productReturned.Price, productReturned.Description);
            
            //return DTO
            return productDTO;
        }
    }
}
