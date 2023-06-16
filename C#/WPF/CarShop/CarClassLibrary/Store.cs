using System;
using System.Collections.Generic;
using System.Text;

namespace CarClassLibrary
{
    public class Store
    {
        //Declare variables with their Getters and Setters
        public List<Car> CarList { get; set; }
        public List<Car> ShoppingList { get; set; }

        //Constructors
        public Store ()
        {
            CarList = new List<Car>();
            ShoppingList = new List<Car>();
        }

        public decimal Checkout()
        {
            decimal totalCost = 0;

            foreach (var c in ShoppingList)
            {
                totalCost += c.Price;
            }

            ShoppingList.Clear();

            return totalCost;
        }
    }
}
