using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Financial_Management_App.Models;
using Microsoft.Extensions.Configuration;
using MySqlConnector;
using Microsoft.Data.SqlClient;

namespace Financial_Management_App.DataAccess
{
    public class UserDaoImp : UserDao
    {
        private readonly string connectionString;

        public UserDaoImp(IConfiguration configuration)
        {
            connectionString = configuration.GetConnectionString("Default");
        }
        // Create 
        public void Register(User user)
        {
            // Encrypt the users password
            user.Password = EncryptPassword(user.Password);

            // Call the DBConnection method with appropriate string.
            DBConnection("INSERT INTO users (Username, Password, First_Name, Last_Name, Balance) VALUES (@Username, @Password, @FirstName, @LastName, @Balance)", user);
        }

        // Read
        public User Login(User user)
        {
            User returnUser = new User();
            user.Password = EncryptPassword(user.Password);
            returnUser = DBConnection("SELECT * FROM users WHERE Username = @Username AND Password = @Password", user);
            if (returnUser.Username != null)
            {
                returnUser.Password = DecryptPassword(returnUser.Password);
            }
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
            return DBConnection("SELECT * FROM users WHERE Username = @Username", new User { Username = username });
        }

        // Update
        public void UpdateBalance(int id, Decimal balance, User user)
        {
            // Call the DBConnection method with appropriate string.
            DBConnection("UPDATE users SET Balance = @Balance WHERE ID = @ID", new User { ID = id, Balance = balance });
        }

        // Connection method.
        private User DBConnection(string statement, User user)
        {

            User returnUser = new User();
            try
            {
                using var connection = new SqlConnection(connectionString);
                connection.Open();
                using var command = new SqlCommand(statement, connection);
                if (statement.Contains("@Username")) command.Parameters.AddWithValue("@Username", user.Username ?? (object)DBNull.Value);
                if (statement.Contains("@Password")) command.Parameters.AddWithValue("@Password", user.Password ?? (object)DBNull.Value);
                if (statement.Contains("@FirstName")) command.Parameters.AddWithValue("@FirstName", user.First_Name ?? (object)DBNull.Value);
                if (statement.Contains("@LastName")) command.Parameters.AddWithValue("@LastName", user.Last_Name ?? (object)DBNull.Value);
                if (statement.Contains("@Balance")) command.Parameters.AddWithValue("@Balance", user.Balance);
                if (statement.Contains("@ID")) command.Parameters.AddWithValue("@ID", user.ID);
                using var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    returnUser.ID = reader.GetInt32(reader.GetOrdinal("ID"));
                    returnUser.Username = reader.GetString(reader.GetOrdinal("Username"));
                    returnUser.Password = reader.GetString(reader.GetOrdinal("Password"));
                    returnUser.First_Name = reader.GetString(reader.GetOrdinal("First_Name"));
                    returnUser.Last_Name = reader.GetString(reader.GetOrdinal("Last_Name"));
                    returnUser.Balance = reader.GetDecimal(reader.GetOrdinal("Balance"));
                }
            }
            catch (SqlException sqlexc)
            {
                Error error = new Error(user.ID, sqlexc.Message, sqlexc.Source, DateTime.Now);
                ErrorLogging(error);
            }
            return returnUser;
            
        }

        // Error logging.
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
            catch (SqlException) { /* Handle silently */ }
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
