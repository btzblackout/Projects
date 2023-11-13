using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Financial_Management_App.Models
{
    public class Expense
    {
        // Declare variables /w Getters & Setters
        private int id;
        public int ID
        {
            get { return this.id; }
            set { this.id = value; }
        }

        private string name;

        [Required(ErrorMessage ="Name is required.")]
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        private Decimal price;
        [Required(ErrorMessage ="Price is required.")]
        [DataType(DataType.Currency)]
        public Decimal Price
        {
            get { return this.price; }
            set { this.price = value; }
        }

        private int interval;
        [Required(ErrorMessage ="Interval is required.")]
        public int Interval
        {
            get { return this.interval; }
            set { this.interval = value; }
        }

        private string type;
        public string Type
        {
            get { return this.type; }
            set { this.type = value; }
        }

        private string label;
        public string Label
        {
            get { return this.label; }
            set { this.label = value; }
        }

        private DateTime date;
        [Required]
        public DateTime Date
        {
            get { return this.date; }
            set {
                this.date = value;
                  this.dateString = this.date.ToString("d"); }
        }

        private String dateString;
        public String DateString
        {
            get { return this.dateString; }
        }

        private string notes;
        public string Notes
        {
            get { return this.notes; }
            set { this.notes = value; }
        }

        private int userId;
        public int UserId
        {
            get { return this.userId; }
            set { this.userId = value; }
        }

        // Declare constructors.
        public Expense()
        {

        }

        public Expense(int id, string name, Decimal price, int interval, string type, string label, DateTime date, string notes, int userId)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.interval = interval;
            this.type = type;
            this.label = label;
            this.date = date;
            this.notes = notes;
            this.userId = userId;
            this.dateString = this.date.ToString("d");
        }
    }
}
