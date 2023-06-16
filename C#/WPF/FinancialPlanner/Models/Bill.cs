using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanner.Models
{
    public class Bill
    {
        //Declare variables.
        private string name;
        private int date;
        private double amount;
        private bool paid;
        private string notes = "";
        private string month;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        
        public int Date
        {
            get { return date; }
            set { date = value; }
        }

        public double Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        public bool Paid
        {
            get { return paid; }
            set { paid = value; }
        }

        public string Notes
        {
            get { return notes; }
            set { notes = value; }
        }

        public string Month
        {
            get { return month; }
            set { month = value; }
        }


        //Constructor
        public Bill()
        {

        }
        public Bill(string name, int date, double amount, bool paid, string month)
        {
            this.name = name;
            this.date = date;
            this.amount = amount;
            this.paid = paid;
            this.month = month;
        }

        public Bill(string name, int date, double amount, bool paid, string notes, string month)
        {
            this.name = name;
            this.date = date;
            this.amount = amount;
            this.paid = paid;
            this.notes = notes;
            this.month = month;
        }

    }
}
