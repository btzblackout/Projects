using Financial_Management_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySqlConnector;
using System.Diagnostics;

namespace Financial_Management_App.DataAccess
{
    public class ExpenseDaoImp : ExpenseDao
    {
        // Create
        public User AddExpense(Expense expense, User user)
        {
            // Call the DBConnection method with appropriate string.
            user = DBConnection("INSERT INTO expenses (Name, Price, `Interval`, Type, Label, Date, Notes, UserID) VALUES ('" + expense.Name + "', " + expense.Price + ", " + expense.Interval + ", '" + expense.Type + "', '" + expense.Label + "', '" + expense.Date.ToString("yyyy-MM-dd") + "', '" + expense.Notes + "', " + expense.UserId + ")", user);
            
            // Return the user.
            return user;
        }

        // Read
        public List<Expense> ReturnExpenseList(User user)
        {
            // Call the DBConnection method with appropriate string.
            user = DBConnection("SELECT * FROM expenses WHERE UserID = '" + user.ID + "'", user);

            // Return the user with the list sorted by date.
            return user.ExpenseList.OrderBy(expense => expense.Date).ToList(); ;
        }

        // Update
        public User EditExpense(Expense expense, User user)
        {
            // Call the DBConnection method with appropriate string.
            DBConnection("UPDATE expenses SET Name = '" + expense.Name + "', Price = " + expense.Price + ", `Interval` = " + expense.Interval + ", Type = '" + expense.Type + "', Label = '" + expense.Label + "', Date = '" + expense.Date.ToString("yyyy-MM-dd") + "', Notes = '" + expense.Notes + "', UserID = " + expense.UserId + " WHERE ID = " + expense.ID, user);

            // Return the user.
            return user;
        }

        // Delete
        public void DeleteExpense(int expenseId, User user)
        {
            // Call the DBConnection method with appropriate string.
            DBConnection("DELETE FROM expenses WHERE ID = '" + expenseId + "'", user);
        }

        // Prevent duplicate expense names.
        public bool CheckForExistingExpense(Expense expense, User user)
        {
            // Create bool for returning.
            bool exists = true;

            // Define the connection parameters. 
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder
            {
                Server = "localhost",
                UserID = "root",
                Password = "root",
                Database = "financial_management"
            };

            // Open the connection.
            using var connection = new MySqlConnection(builder.ConnectionString);
            connection.Open();

            // Create a DB command
            using var command = connection.CreateCommand();
            command.CommandText = "SELECT * from expenses WHERE Name = '" + expense.Name + "' AND UserID = " + user.ID;

            //If ExecuteScalar is Null then the expense does not exist.
            if (command.ExecuteScalar() == null)
            {
                exists = false;
            }

            // Close the connection.
            connection.Close();

            // Return the bool. 
            return exists;
        }

        // Connection method. 
        private User DBConnection(string statement, User user)
        {
            try
            {
                // Create the connection properties.
                MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder
                {
                    Server = "localhost",
                    UserID = "root",
                    Password = "root",
                    Database = "financial_management"
                };

                // Create an empty list to add to return User.
                List<Expense> expenseList = new List<Expense>();

                // Open the connection.
                using var connection = new MySqlConnection(builder.ConnectionString);
                connection.Open();

                // Create a DB command
                using var command = connection.CreateCommand();
                command.CommandText = statement;

                // Execute the command.
                using var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    // Grab the values from the DB.
                    var id = reader.GetInt32("ID");
                    var name = reader.GetString("Name");
                    var price = reader.GetDecimal("Price");
                    var interval = reader.GetByte("Interval");
                    var type = reader.GetString("Type");
                    var label = reader.GetString("Label");
                    var date = reader.GetDateTime("Date");
                    var notes = reader.GetString("Notes");
                    var userId = reader.GetInt32("UserID");

                    // Add the expense to the users list.
                    user.ExpenseList.Add(new Expense(id, name, price, interval, type, label, date.Date, notes, userId)); 
                }
                // Close the connection.
                connection.Close();
            }
            catch (MySqlException sqlexc)
            {
                // Create an error object.
                Error error = new Error(user.ID, sqlexc.Message, sqlexc.Source, DateTime.Now);
                ErrorLogging(error);
            }
            // Return the user.
            return user;

        }

        // Error logging.
        private void ErrorLogging(Error error)
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder
            {
                Server = "localhost",
                UserID = "root",
                Password = "root",
                Database = "financial_management"
            };

            // Open the connection.
            using var connection = new MySqlConnection(builder.ConnectionString);
            connection.Open();

            // Create a DB command
            using var command = connection.CreateCommand();
            command.CommandText = "INSERT INTO errors (Message, Source, Date, UserID) VALUES ('" + error.Message + "', '" + error.Source + "', '" + error.Date + "', " + error.UserID + ")";

            // Execute the command.
            command.ExecuteNonQuery();

            // Close the connection.
            connection.Close();
        }

    }
}
