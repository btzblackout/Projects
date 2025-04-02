using Financial_Management_App.Models;
using Microsoft.Data.SqlClient; 
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Financial_Management_App.DataAccess
{
    public class ExpenseDaoImp : ExpenseDao
    {
        private readonly string connectionString;

        public ExpenseDaoImp(IConfiguration configuration)
        {
            connectionString = configuration.GetConnectionString("Default");
        }

        // Create
        public User AddExpense(Expense expense, User user)
        {
            return DBConnection("INSERT INTO expenses (Name, Price, [Interval], Type, Label, Date, Notes, UserID) VALUES (@Name, @Price, @Interval, @Type, @Label, @Date, @Notes, @UserID)", expense, user);
        }

        // Read
        public List<Expense> ReturnExpenseList(User user)
        {
            user = DBConnection("SELECT * FROM expenses WHERE UserID = @UserID", null, user);
            return user.ExpenseList.OrderBy(expense => expense.Date).ToList();
        }

        // Update
        public User EditExpense(Expense expense, User user)
        {
            DBConnection("UPDATE expenses SET Name = @Name, Price = @Price, [Interval] = @Interval, Type = @Type, Label = @Label, Date = @Date, Notes = @Notes, UserID = @UserID WHERE ID = @ID", expense, user);
            return user;
        }

        // Delete
        public void DeleteExpense(int expenseId, User user)
        {
            DBConnection("DELETE FROM expenses WHERE ID = @ID", new Expense { ID = expenseId }, user);
        }

        // Prevent duplicate expense names
        public bool CheckForExistingExpense(Expense expense, User user)
        {
            bool exists = true;
            try
            {
                using var connection = new SqlConnection(connectionString);
                connection.Open();
                using var command = new SqlCommand("SELECT COUNT(*) FROM expenses WHERE Name = @Name AND UserID = @UserID", connection);
                command.Parameters.AddWithValue("@Name", expense.Name);
                command.Parameters.AddWithValue("@UserID", user.ID);
                exists = (int)command.ExecuteScalar() > 0;
            }
            catch (SqlException sqlexc)
            {
                ErrorLogging(new Error(user.ID, sqlexc.Message, sqlexc.Source, DateTime.Now));
            }
            return exists;
        }

        // Connection method
        private User DBConnection(string statement, Expense expense, User user)
        {
            try
            {
                using var connection = new SqlConnection(connectionString);
                connection.Open();
                using var command = new SqlCommand(statement, connection);

                // Add parameters if expense is provided
                if (expense != null)
                {
                    command.Parameters.AddWithValue("@ID", expense.ID);
                    command.Parameters.AddWithValue("@Name", expense.Name ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@Price", expense.Price);
                    command.Parameters.AddWithValue("@Interval", expense.Interval);
                    command.Parameters.AddWithValue("@Type", expense.Type ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@Label", expense.Label ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@Date", expense.Date);
                    command.Parameters.AddWithValue("@Notes", expense.Notes ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@UserID", expense.UserId);
                }
                else if (statement.Contains("@UserID"))
                {
                    command.Parameters.AddWithValue("@UserID", user.ID);
                }

                using var reader = command.ExecuteReader();
                if (statement.Contains("SELECT"))
                {
                    user.ExpenseList.Clear(); // Reset list for fresh data
                    while (reader.Read())
                    {
                        if (reader.IsDBNull(reader.GetOrdinal("Notes")))
                        {
                            user.ExpenseList.Add(new Expense(
                            reader.GetInt32(reader.GetOrdinal("ID")),
                            reader.GetString(reader.GetOrdinal("Name")),
                            reader.GetDecimal(reader.GetOrdinal("Price")),
                            reader.GetInt32(reader.GetOrdinal("Interval")),
                            reader.GetString(reader.GetOrdinal("Type")),
                            reader.GetString(reader.GetOrdinal("Label")),
                            reader.GetDateTime(reader.GetOrdinal("Date")),
                            "",
                            reader.GetInt32(reader.GetOrdinal("UserID"))
                        ));
                        }
                        else
                        {
                            user.ExpenseList.Add(new Expense(
                                reader.GetInt32(reader.GetOrdinal("ID")),
                                reader.GetString(reader.GetOrdinal("Name")),
                                reader.GetDecimal(reader.GetOrdinal("Price")),
                                reader.GetInt32(reader.GetOrdinal("Interval")),
                                reader.GetString(reader.GetOrdinal("Type")),
                                reader.GetString(reader.GetOrdinal("Label")),
                                reader.GetDateTime(reader.GetOrdinal("Date")),
                                reader.GetString(reader.GetOrdinal("Notes")),
                                reader.GetInt32(reader.GetOrdinal("UserID"))
                            ));
                        }
                    }
                }
            }
            catch (SqlException sqlexc)
            {
                ErrorLogging(new Error(user.ID, sqlexc.Message, sqlexc.Source, DateTime.Now));
            }
            return user;
        }

        // Error logging
        private void ErrorLogging(Error error)
        {
            try
            {
                using var connection = new SqlConnection(connectionString);
                connection.Open();
                using var command = new SqlCommand(
                    "INSERT INTO errors (Message, Source, Date, UserID) VALUES (@Message, @Source, @Date, @UserID)",
                    connection);
                command.Parameters.AddWithValue("@Message", error.Message);
                command.Parameters.AddWithValue("@Source", error.Source);
                command.Parameters.AddWithValue("@Date", error.Date);
                command.Parameters.AddWithValue("@UserID", error.UserID);
                command.ExecuteNonQuery();
            }
            catch (SqlException) { /* Silent fail */ }
        }
    }
}