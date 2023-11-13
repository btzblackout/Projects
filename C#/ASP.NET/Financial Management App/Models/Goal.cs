using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Financial_Management_App.Models
{
    public class Goal
    {
        // Declare variables /w Getters & Setters
        private int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        private string name;

        [Required]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private Decimal price;
        [Required]
        [DataType(DataType.Currency)]
        public Decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        private DateTime date;
        public DateTime Date
        {
            get { return date; }
            set { date = value;
                date_String = date.ToString("d");
            }
        }

        private string date_String;

        public string Date_String
        {
            get { return date_String; }
            set { date_String = value; }
        }


        private int priority;

        public int Priority
        {
            get { return priority; }
            set { priority = value; }
        }

        private Decimal savedAmount;
        [Required]
        [DataType(DataType.Currency)]
        public Decimal SavedAmount
        {
            get { return savedAmount; }
            set { savedAmount = value; }
        }

        private string notes;

        public string Notes
        {
            get { return notes; }
            set { notes = value; }
        }

        private int userID;

        public int UserID
        {
            get { return userID; }
            set { userID = value; }
        }

        private int numOfPaychecks;

        public int NumOfPaychecks
        {
            get { return numOfPaychecks; }
            set { numOfPaychecks = value; }
        }


        // Declare constructors
        public Goal()
        {

        }

        public Goal(int id, string name, Decimal price, DateTime date, int priority, Decimal savedAmount, int numOfPaychecks, string notes, int userID)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.date = date;
            this.priority = priority;
            this.savedAmount = savedAmount;
            this.numOfPaychecks = numOfPaychecks;
            this.notes = notes;
            this.userID = userID;
        }







    }
}
