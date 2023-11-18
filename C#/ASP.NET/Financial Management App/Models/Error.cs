using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySqlConnector;

namespace Financial_Management_App.Models
{
    public class Error
    {
        // Declare variables and getters & setters.

        private int userID;

        public int UserID
        {
            get { return userID; }
            set { userID = value; }
        }

        private string message;
        public string Message
        {
            get { return message; }
            set { message = value; }
        }

        private string source;
        public string Source
        {
            get { return source; }
            set { source = value; }
        }

        private DateTime date;
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        // Declare constructors.
        public Error()
        {
            
        }

        public Error (int userID, string message, string source, DateTime date)
        {
            this.userID = userID;
            this.message = message;
            this.source = source;
            this.date = date;
        }
    }
}
