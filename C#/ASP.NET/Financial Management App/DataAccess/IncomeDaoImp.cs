using Financial_Management_App.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;

namespace Financial_Management_App.DataAccess
{
    public class IncomeDaoImp : IncomeDao
    {
        private readonly string connectionString;

        public IncomeDaoImp(IConfiguration configuration)
        {
            connectionString = configuration.GetConnectionString("Default");
        }

        // Create
        public void AddIncome(Income income, User user)
        {
            DBConnection("INSERT INTO income (Name, Amount, Begin_Date, End_Date, [Interval], Type, Next_Pay_Begin, Next_Pay_End, Notes, UserID) VALUES (@Name, @Amount, @BeginDate, @EndDate, @Interval, @Type, @NextPayBegin, @NextPayEnd, @Notes, @UserID)", income, user);
        }

        // Read
        public List<Income> ReturnIncomeList(User user)
        {
            return DBConnection("SELECT * FROM income WHERE UserID = @UserID", null, user);
        }

        // Update
        public bool UpdateIncome(Income income, User user)
        {
            DBConnection("UPDATE income SET Name = @Name, Amount = @Amount, Begin_Date = @BeginDate, End_Date = @EndDate, [Interval] = @Interval, Type = @Type, Next_Pay_Begin = @NextPayBegin, Next_Pay_End = @NextPayEnd, Notes = @Notes WHERE ID = @ID", income, user);
            return true;
        }

        // Delete
        public bool DeleteIncome(Income income, User user)
        {
            user.IncomeList = DBConnection("DELETE FROM income WHERE ID = @ID", income, user);
            return user.IncomeList.Count == 0;
        }

        // Check if income name exists
        public bool CheckIncomeName(Income income, User user)
        {
            bool exists = true;
            try
            {
                using var connection = new SqlConnection(connectionString);
                connection.Open();
                using var command = new SqlCommand("SELECT COUNT(*) FROM income WHERE Name = @Name AND UserID = @UserID", connection);
                command.Parameters.AddWithValue("@Name", income.Name);
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
        private List<Income> DBConnection(string statement, Income income, User user)
        {
            List<Income> incomeList = new List<Income>();
            try
            {
                using var connection = new SqlConnection(connectionString);
                connection.Open();
                using var command = new SqlCommand(statement, connection);

                if (income != null)
                {
                    command.Parameters.AddWithValue("@ID", income.ID);
                    command.Parameters.AddWithValue("@Name", income.Name ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@Amount", income.Amount);
                    command.Parameters.AddWithValue("@BeginDate", income.Begin_Date);
                    command.Parameters.AddWithValue("@EndDate", income.End_Date);
                    command.Parameters.AddWithValue("@Interval", income.Interval);
                    command.Parameters.AddWithValue("@Type", income.Type ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@NextPayBegin", income.Next_Pay_Begin);
                    command.Parameters.AddWithValue("@NextPayEnd", income.Next_Pay_End);
                    command.Parameters.AddWithValue("@Notes", income.Notes ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@UserID", income.UserId);
                }
                else if (statement.Contains("@UserID"))
                {
                    command.Parameters.AddWithValue("@UserID", user.ID);
                }

                using var reader = command.ExecuteReader();
                if (statement.Contains("SELECT"))
                {
                    string notes = "";
                    while (reader.Read())
                    {
                        if (!reader.IsDBNull(reader.GetOrdinal("Notes")))
                        {
                            notes = reader.GetString(reader.GetOrdinal("Notes"));
                        }

                        var newIncome = new Income
                        (
                            reader.GetInt32(reader.GetOrdinal("ID")),
                            reader.GetString(reader.GetOrdinal("Name")),
                            reader.GetDecimal(reader.GetOrdinal("Amount")),
                            reader.GetDateTime(reader.GetOrdinal("Begin_Date")),
                            reader.GetDateTime(reader.GetOrdinal("End_Date")),
                            reader.GetInt32(reader.GetOrdinal("Interval")),
                            reader.GetString(reader.GetOrdinal("Type")),
                            reader.GetDateTime(reader.GetOrdinal("Next_Pay_Begin")),
                            reader.GetDateTime(reader.GetOrdinal("Next_Pay_End")),
                            notes,
                            reader.GetInt32(reader.GetOrdinal("UserID"))
                        );
                           
                        newIncome.Next_Pay_Begin_String = newIncome.Next_Pay_Begin.ToString("d");
                        newIncome.Next_Pay_End_String = newIncome.Next_Pay_End.ToString("d");
                        incomeList.Add(newIncome);
                    }
                }
            }
            catch (SqlException sqlexc)
            {
                ErrorLogging(new Error(user.ID, sqlexc.Message, sqlexc.Source, DateTime.Now));
            }
            return incomeList;
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