using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASPCoreFirstApp.Models
{
    public class ProductModel
    {
        // Variables.
        [DisplayName("Id number")]
        public int Id { get; set; }
        [DisplayName("Product Name")]
        public string Name { get; set; }
        [DataType(DataType.Currency)]
        [DisplayName("Cost to customer")]
        public decimal Price { get; set; }
        [DisplayName("What you get...")]
        public string Description { get; set; }

        //Constructors.
        public ProductModel(int id, string name, decimal price, string description)
        {
            Id = id;
            Name = name;
            Price = price;
            Description = description;
        }

        public ProductModel()
        {

        }
    }
}
