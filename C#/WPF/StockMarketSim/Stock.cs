using System;
using System.Collections.Generic;
using System.Text;

namespace StockMarketSim
{
    class Stock
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private double price;

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        //Constructors
        public Stock(string name, double price)
        {
            this.name = name;
            this.price = price;
        }
        public Stock()
        {

        }
    }
}
