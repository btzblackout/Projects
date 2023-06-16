using System;
using System.Collections.Generic;
using System.Text;

namespace StockMarketSim
{

    public class Company
    {
        //Variables

        private string name;
        private string symbol;
        private decimal price;
        private decimal change;
        private float percentChange;
        private double volume;
        private char volumeChar;
        private double marketCap;
        private char marketCapChar;
        private decimal equity;

        //Constructors
        public Company()
        {

        }
        public Company(string name, string symbol, decimal price, decimal change, float percentChange, double volume, char volumeChar, double marketCap, char marketCapChar, decimal equity)
        {
            this.name = name;
            this.symbol = symbol;
            this.price = price;
            this.change = change;
            this.percentChange = percentChange;
            this.volume = volume;
            this.volumeChar = volumeChar;
            this.marketCap = marketCap;
            this.marketCapChar = marketCapChar;
            this.equity = equity;
        }
        
        //Getters and Setters
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Symbol
        {
            get { return symbol; }
            set { symbol = value; }
        }
        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }
        public decimal Change
        {
            get { return change; }
            set { change = value; }
        }
        public float PercentChange
        {
            get { return percentChange; }
            set { percentChange = value; }
        }
        public double Volume
        {
            get { return volume; }
            set { volume = value; }
        }
        public char VolumeChar
        {
            get { return volumeChar; }
            set { volumeChar = value; }
        }
        public double MarketCap
        {
            get { return marketCap; }
            set { marketCap = value; }
        }
        public char MarketCapChar
        {
            get { return marketCapChar; }
            set { marketCapChar = value; }
        }
        public decimal Equity
        {
            get { return equity; }
            set { equity = value; }
        }

    }
}
