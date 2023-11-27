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
        // Create 
        public void Register(User user)
        {
            // Encrypt the users password
            user.Password = EncryptPassword(user.Password);

            // Call the DBConnection method with appropriate string.
            DBConnection("INSERT INTO users (Username, Password, First_Name, Last_Name, Balance) VALUES ('" + user.Username + "', '" + user.Password + "', '" + user.First_Name + "', '" + user.Last_Name + "', " + user.Balance + ")", user);
        }

        // Read
        public User Login(User user)
        {
            // Create new user.
            User returnUser = new User();

            // Encrypt the users password
            user.Password = EncryptPassword(user.Password);

            // Call the DBConnection method with appropriate string
            returnUser = DBConnection("SELECT * FROM users WHERE Username = '" + user.Username + "' AND Password = '" + user.Password + "'", user);

            Debug.WriteLine(EncryptPassword("admin"));
            // If the returnUser is null then skip
            if(returnUser.Username != null)
            {
                // Decrypt the users password
                returnUser.Password = DecryptPassword(returnUser.Password);
            }
 
            // return the user
            return returnUser;
        }

        // Check if the username already exists.
        public User CheckByUsername(string username)
        {
            // There will be no user because the user is attempting to create one.
            User user = new User();

            // Give the user ID 0, all 0's in the DB should always be in this DB.
            user.ID = 0;

            // Call the DBConnection method with appropriate string and return user.
            User returnUser = DBConnection("SELECT * FROM users WHERE Username = '" + username + "'", user);
            return returnUser;
        }

        // Update
        public void UpdateBalance(int id, Decimal balance, User user)
        {
            // Call the DBConnection method with appropriate string.
            DBConnection("UPDATE users SET Balance = " + balance + " WHERE ID = " + id, user);
        }

        // Connection method.
        private User DBConnection(string statement, User user)
        {
            User returnUser = new User();
            try
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
            }
            catch (MySqlException sqlexc)
            {
                // Create an error object.
                Error error = new Error(user.ID, sqlexc.Message, sqlexc.Source, DateTime.Now);
                ErrorLogging(error);
            }


            return returnUser;
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

        // Encode password.
        private string EncryptPassword(string password)
        {
            try
            {
                // Create a byte array.
                byte[] byteString = new byte[password.Length];

                // Encode the password and save to the byte array.
                byteString = System.Text.Encoding.UTF8.GetBytes(password);

                // Convert the byte array to a string.
                string encodedPassword = Convert.ToBase64String(byteString);

                // Return the string.
                return encodedPassword;
            }
            catch (Exception e)
            {

                throw new Exception("Error encrypting " + e.Message);
            }
        }

        // Decode password.
        private string DecryptPassword(string password)
        {
            // Create the encoder.
            System.Text.UTF8Encoding encoder = new System.Text.UTF8Encoding();

            // Create the decoder.
            System.Text.Decoder utf8Decoder = encoder.GetDecoder();

            // Convert the encrypted password from string to byte array.
            byte[] byteToDecode = Convert.FromBase64String(password);

            // Get the character count of the byte array.
            int charCount = utf8Decoder.GetCharCount(byteToDecode, 0, byteToDecode.Length);

            // Create the char array to hold the decoded password.
            char[] decodedPassword = new char[charCount];

            utf8Decoder.GetChars(byteToDecode, 0, byteToDecode.Length, decodedPassword, 0);

            // Convert the decoded password char array to a string
            string result = new string(decodedPassword);

            // Return the string.
            return result;
        }
    }
}
