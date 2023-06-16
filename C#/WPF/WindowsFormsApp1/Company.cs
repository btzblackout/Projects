using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Company
    {
        //Variables

        private string name;
        private string symbol;
        private decimal price;
        private decimal change;
        private char changeOperator;
        private float percentChange;
        private double volume;
        private char volumeChar;
        private double marketCap;
        private char marketCapChar;
        private long equity;
        private char equityChar;
        //Constructors
        public Company()
        {

        }
        public Company(string name, string symbol, decimal price, decimal change, char changeOperator, float percentChange, double volume, char volumeChar, double marketCap, char marketCapChar, long equity, char equityChar)
        {
            this.name = name;
            this.symbol = symbol;
            this.price = price;
            this.change = change;
            this.changeOperator = changeOperator;
            this.percentChange = percentChange;
            this.volume = volume;
            this.volumeChar = volumeChar;
            this.marketCap = marketCap;
            this.marketCapChar = marketCapChar;
            this.equity = equity;
            this.equityChar = equityChar;
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
        public char ChangeOperator
        {
            get { return changeOperator; }
            set { changeOperator = value; }
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
        public long Equity
        {
            get { return equity; }
            set { equity = value; }
        }
        public char EquityChar
        {
            get { return equityChar; }
            set { equityChar = value; }
        }

    }
}
