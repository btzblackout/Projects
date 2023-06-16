using ASPCoreFirstApp.Models;
using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPCoreFirstApp.Services
{
    public class HardCodedSampleDataRepository : IProductsDataService
    {
        //Declare variables.
        static List<ProductModel> productList;      //Static to ensure the contents do not change.

        //Create constructor.
        public HardCodedSampleDataRepository()
        {
            productList = new List<ProductModel>();
            //Populate the list.
            productList.Add(new ProductModel(1, "Mouse Pad", 5.99m, "A square piece of plastic to make mousing easier."));
            productList.Add(new ProductModel(2, "Web Cam", 45.50m, "Enables you to attend more zoom meetings."));
            productList.Add(new ProductModel(3, "4 TB USB Hard Drive", 130.00m, "Back up all of your work. You won't regret it."));
            productList.Add(new ProductModel(4, "Wireless Mouse", 15.99m, "Notebook mice really don't work very well. Do they?"));

            //Create 100 more entries into the list and use Faker to generate fake data. 
            for (int i = 0; i < 100; i++)
            {
                productList.Add(new Faker<ProductModel>()
                .RuleFor(p => p.Id, i + 5)
                .RuleFor(p => p.Name, f => f.Commerce.ProductName())
                .RuleFor(p => p.Price, f => f.Random.Decimal(100))
                .RuleFor(p => p.Description, f => f.Rant.Review())
                );
            }
        }

        //Implement interface methods.

        //This method is for returning a list of all products.
        public List<ProductModel> AllProducts()
        {
            return productList;
        }

        //This method is for deleting a specific product.
        public bool Delete(ProductModel product)
        {
            throw new NotImplementedException();
        }

        //This method is for searching for a product by its ID.
        public ProductModel GetProductById(int id)
        {
            throw new NotImplementedException();
        }

        //This method is for inserting a product into the list.
        public int Insert(ProductModel product)
        {
            throw new NotImplementedException();
        }

        //This method is for searching for a product by a term.
        public List<ProductModel> SearchProducts(string searchTerm)
        {
            throw new NotImplementedException();
        }

        //This method is for updating an existing product.
        public int Update(ProductModel product)
        {
            throw new NotImplementedException();
        }
    }
}
