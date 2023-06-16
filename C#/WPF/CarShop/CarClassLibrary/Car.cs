using System;
using System.Collections.Generic;
using System.Text;

namespace CarClassLibrary
{
    public class Car
    {
        //Declare variables with their Getters and Setters
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }
        

        //Constructors
        public Car (string make, string model, string color, int year, decimal price)
        {
            Make = make;
            Model = model;
            Color = color;
            Year = year;
            Price = price;
        }

        public Car ()
        {
            Make = "Nothing yet";
            Model = "Nothing yet";
            Color = "Nothing yet";
            Year = 0;
            Price = 0;
        }

        public string Display
        {
            get
            {
                return string.Format("{0} {1} {2} {3} ${4}", Year, Color, Make, Model, Price);
            }
        }
    }
}
