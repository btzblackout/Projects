using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Financial_Management_App.Models
{
    public class Income
    {
        // Declare variables /w Getters & Setters
        private int id;
        public int ID
        {
            get { return this.id; }
            set { this.id = value; }
        }

        private string name;

        [Required]
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        private Decimal amount;

        [Required]
        [DataType(DataType.Currency)]
        public Decimal Amount
        {
            get { return this.amount; }
            set { this.amount = value; }
        }

        private DateTime begin_date;

        [Required]
        public DateTime Begin_Date
        {
            get { return this.begin_date; }
            set { this.begin_date = value; 
                this.begin_date_string = this.begin_date.ToString("d"); }
        }

        private String begin_date_string;
        public String Begin_Date_String
        {
            get { return this.begin_date_string; }
        }

        private DateTime end_date;
        public DateTime End_Date
        {
            get { return this.end_date; }
            set { this.end_date = value; 
                this.end_date_string = this.end_date.ToString("d"); }
        }

        private String end_date_string;
        public String End_Date_String
        {
            get { return this.end_date_string; }
        }

        private int interval;
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

        private DateTime next_Pay_Begin;

        public DateTime Next_Pay_Begin
        {
            get { return next_Pay_Begin; }
            set { this.next_Pay_Begin = value;
                this.next_Pay_Begin_String = this.next_Pay_Begin.ToString("d");}
        }

        private String next_Pay_Begin_String;
        public String Next_Pay_Begin_String
        {
            get { return this.next_Pay_Begin_String; }
            set { this.next_Pay_Begin_String = value; }
        }

        private DateTime next_Pay_End;

        public DateTime Next_Pay_End
        {
            get { return next_Pay_End; }
            set { next_Pay_End = value;}
        }

        private String next_Pay_End_String;
        public String Next_Pay_End_String
        {
            get { return this.next_Pay_End_String; }
            set { this.next_Pay_End_String = value; }
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


        // Create constructors

        public Income()
        {

        }

        public Income(int id, string name, Decimal amount, DateTime begin_date, DateTime end_date, int interval, string type, DateTime next_Pay_Begin, DateTime next_Pay_End, string notes, int userId)
        {
            this.id = id;
            this.name = name;
            this.amount = amount;
            this.begin_date = begin_date;
            this.end_date = end_date;
            this.interval = interval;
            this.type = type;
            this.next_Pay_Begin = next_Pay_Begin;
            this.next_Pay_End = next_Pay_End;
            this.notes = notes;
            this.userId = userId;
            this.begin_date_string = this.begin_date.ToString("d");
            this.end_date_string = this.end_date.ToString("d");
        }

    }
}
