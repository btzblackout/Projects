using Financial_Management_App.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;

namespace Financial_Management_App.DataAccess
{
    public class GoalDaoImp : GoalDao
    {
        private readonly string connectionString;

        public GoalDaoImp(IConfiguration configuration)
        {
            connectionString = configuration.GetConnectionString("Default");
        }

        // Create
        public void AddGoal(Goal goal, User user)
        {
            DBConnection("INSERT INTO goals (Name, Price, Date, Priority, Save_Amount, Number_Of_Paychecks, Notes, UserID) VALUES (@Name, @Price, @Date, @Priority, @SaveAmount, @NumberOfPaychecks, @Notes, @UserID)", goal, user);
        }

        // Read
        public List<Goal> ReturnGoalList(User user)
        {
            return DBConnection("SELECT * FROM goals WHERE UserID = @UserID", null, user);
        }

        // Update
        public bool UpdateGoal(Goal goal, User user)
        {
            DBConnection("UPDATE goals SET Name = @Name, Price = @Price, Date = @Date, Priority = @Priority, Save_Amount = @SaveAmount, Notes = @Notes WHERE ID = @ID", goal, user);
            return true;
        }

        // Delete
        public bool DeleteGoal(Goal goal, User user)
        {
            DBConnection("DELETE FROM goals WHERE ID = @ID", goal, user);
            return true;
        }

        // Connection method
        private List<Goal> DBConnection(string statement, Goal goal, User user)
        {
            List<Goal> goalList = new List<Goal>();
            try
            {
                using var connection = new SqlConnection(connectionString);
                connection.Open();
                using var command = new SqlCommand(statement, connection);

                if (goal != null)
                {
                    command.Parameters.AddWithValue("@ID", goal.ID);
                    command.Parameters.AddWithValue("@Name", goal.Name ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@Price", goal.Price);
                    command.Parameters.AddWithValue("@Date", goal.Date);
                    command.Parameters.AddWithValue("@Priority", goal.Priority);
                    command.Parameters.AddWithValue("@SaveAmount", goal.SavedAmount);
                    command.Parameters.AddWithValue("@NumberOfPaychecks", goal.NumOfPaychecks);
                    command.Parameters.AddWithValue("@Notes", goal.Notes ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@UserID", goal.UserID);
                }
                else if (statement.Contains("@UserID"))
                {
                    command.Parameters.AddWithValue("@UserID", user.ID);
                }

                using var reader = command.ExecuteReader();
                if (statement.Contains("SELECT"))
                {
                    while (reader.Read())
                    {
                        var newGoal = new Goal(
                            reader.GetInt32(reader.GetOrdinal("ID")),
                            reader.GetString(reader.GetOrdinal("Name")),
                            reader.GetDecimal(reader.GetOrdinal("Price")),
                            reader.GetDateTime(reader.GetOrdinal("Date")),
                            reader.GetInt32(reader.GetOrdinal("Priority")),
                            reader.GetDecimal(reader.GetOrdinal("Save_Amount")),
                            reader.GetInt32(reader.GetOrdinal("Number_Of_Paychecks")),
                            reader.GetString(reader.GetOrdinal("Notes")),
                            reader.GetInt32(reader.GetOrdinal("UserID"))
                        );
                        newGoal.Date_String = newGoal.Date.ToString("d");
                        goalList.Add(newGoal);
                    }
                }
            }
            catch (SqlException sqlexc)
            {
                ErrorLogging(new Error(user.ID, sqlexc.Message, sqlexc.Source, DateTime.Now));
            }
            return goalList;
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