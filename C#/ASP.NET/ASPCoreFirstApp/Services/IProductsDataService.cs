using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPCoreFirstApp.Models;

namespace ASPCoreFirstApp.Services
{
    public interface IProductsDataService
    {
        //Return a list of all of the products.
        List<ProductModel> AllProducts();
        //Search for specific product by search term.
        List<ProductModel> SearchProducts(string searchTerm);
        //CRUD - CREATE
        int Insert(ProductModel product);
        //CRUD - READ
        ProductModel GetProductById(int id);
        //CRUD - UPDATE
        int Update(ProductModel product);
        //CRUD - DELETE
        bool Delete(ProductModel product);


    }
}
