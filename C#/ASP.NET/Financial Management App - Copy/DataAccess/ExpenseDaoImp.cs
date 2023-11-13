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
            user = DBConnection("INSERT INTO expenses (Name, Price, `Interval`, Type, Label, Date, Notes, UserID) VALUES ('" + expense.Name + "', " + expense.Price + ", " + expense.Interval + ", '" + expense.Type + "', '" + expense.Label + "', '" + expense.Date.ToString("yyyy-MM-dd") + "', '" + expense.Notes + "', " + expense.UserId + ")", user);
            return user;
        }

        // Read
        public List<Expense> ReturnExpenseList(User user)
        {
            user = DBConnection("SELECT * FROM expenses WHERE UserID = '" + user.ID + "'", user);
            return user.ExpenseList.OrderBy(expense => expense.Date).ToList(); ;
        }

        // Update
        public User EditExpense(Expense expense, User user)
        {
            DBConnection("UPDATE expenses SET Name = '" + expense.Name + "', Price = " + expense.Price + ", `Interval` = " + expense.Interval + ", Type = '" + expense.Type + "', Label = '" + expense.Label + "', Date = '" + expense.Date.ToString("yyyy-MM-dd") + "', Notes = '" + expense.Notes + "', UserID = " + expense.UserId + " WHERE ID = " + expense.ID, user);
            return user;
        }

        // Delete
        public void RemoveExpense(int expenseId, User user)
        {
            DBConnection("DELETE FROM expenses WHERE ID = '" + expenseId + "'", user);
        }

        // Check if expense name exists.
        public bool CheckForExistingExpense(Expense expense, User user)
        {
            bool exists = true;

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

            return exists;
        }

        // Connection method. 
        private User DBConnection(string statement, User user)
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder
            {
                Server = "localhost",
                UserID = "root",
                Password = "root",
                Database = "financial_management"
            };

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
                var id = reader.GetInt32("ID");
                var name = reader.GetString("Name");
                var price = reader.GetDecimal("Price");
                var interval = reader.GetByte("Interval");
                var type = reader.GetString("Type");
                var label = reader.GetString("Label");
                var date = reader.GetDateTime("Date");
                var notes = reader.GetString("Notes");
                var userId = reader.GetInt32("UserID");

                user.ExpenseList.Add(new Expense(id, name, price, interval, type, label, date.Date, notes, userId));

            }

            // Close the connection.
            connection.Close();
            return user;

        }

    }
}
