using Financial_Management_App.Models;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Financial_Management_App.DataAccess
{
    public class GoalDaoImp : GoalDao
    {
        // Create
        public void AddGoal(Goal goal, User user)
        {
            // Call the DBConnection method with appropriate string.
            DBConnection("INSERT INTO goals (Name, Price, Date, Priority, Save_Amount, Number_Of_Paychecks, Notes, UserID) VALUES ('" + goal.Name + "', " + goal.Price + ", '" + goal.Date.ToString("yyyy-MM-dd") + "', " + goal.Priority + ", " + goal.SavedAmount + ", " + goal.NumOfPaychecks + ", '" + goal.Notes + "', " + goal.UserID + ")", user);
        }

        // Read
        public List<Goal> ReturnGoalList(User user)
        {
            // Call the DBConnection method with appropriate string and return the result list.
            return DBConnection("SELECT * FROM goals WHERE UserID = " + user.ID, user);
        }

        // Update
        public bool UpdateGoal(Goal goal, User user)
        {
            // Call the DBConnection method with appropriate string.
            DBConnection("UPDATE goals SET Name = '" + goal.Name + "', Price = " + goal.Price + ", Date = '" + goal.Date.ToString("yyyy-MM-dd") + "', Priority = " + goal.Priority + ", Save_Amount = " + goal.SavedAmount + ", Notes = '" + goal.Notes + "' WHERE ID = " + goal.ID, user);

            
            return true;
        }

        // Delete
        public bool DeleteGoal(Goal goal, User user)
        {
            DBConnection("DELETE FROM goals WHERE ID = " + goal.ID, user);
            return true;
        }

        // Connection method. 
        private List<Goal> DBConnection(string statement, User user)
        {
            // Create an empty list for return.
            List<Goal> goalList = new List<Goal>();
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
                    // Grab all columns in the goals table.
                    var id = reader.GetInt32("ID");
                    var name = reader.GetString("Name");
                    var price = reader.GetDecimal("Price");
                    var date = reader.GetDateTime("Date");
                    var priority = reader.GetInt32("Priority");
                    var saveAmount = reader.GetDecimal("Save_Amount");
                    var numOfPaychecks = reader.GetInt32("Number_Of_Paychecks");
                    var notes = reader.GetString("Notes");
                    var userId = reader.GetInt32("UserID");

                    // Create the goal.
                    Goal goal = new Goal(id, name, price, date.Date, priority, saveAmount, numOfPaychecks, notes, userId);
                    // Set the date string.
                    goal.Date_String = goal.Date.ToString("d");
                    // Add the goal to the goal list.
                    goalList.Add(goal);

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

            return goalList;

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
