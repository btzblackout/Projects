using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Financial_Management_App.Models;
using MySqlConnector;

namespace Financial_Management_App.DataAccess
{
    public class UserDaoImp : UserDao
    {

        private User DBConnection(string statement)
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder
            {
                Server = "localhost",
                UserID = "root",
                Password = "root",
                Database = "financial_management"
            };

            User returnUser = new User();

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
                var username = reader.GetString("Username");
                var password = reader.GetString("Password");
                var first_name = reader.GetString("First_Name");
                var last_name = reader.GetString("Last_Name");
                var balance = reader.GetDecimal("Balance");

                returnUser.ID = id;
                returnUser.Username = username;
                returnUser.Password = password;
                returnUser.First_Name = first_name;
                returnUser.Last_Name = last_name;
                returnUser.Balance = balance;

            }

            // Close the connection.
            connection.Close();

            return returnUser;
        }
        public User CheckByUsername(string username)
        {

            User returnUser = DBConnection("SELECT * FROM users WHERE Username = '" + username + "'");
            return returnUser;
        }

        public User Login(User user)
        {
            User returnUser = new User();
            return returnUser = DBConnection("SELECT * FROM users WHERE Username = '" + user.Username + "' AND Password = '" + user.Password + "'");   
        }

        public void Register(User user)
        {
            DBConnection("INSERT INTO users (Username, Password, First_Name, Last_Name, Balance) VALUES ('" + user.Username + "', '" + user.Password + "', '" + user.First_Name + "', '" + user.Last_Name + "', " + user.Balance +")");
        }

        public void UpdateBalance(int id, Decimal balance)
        {
            DBConnection("UPDATE users SET Balance = " + balance + " WHERE ID = " + id);
        }
    }
}
