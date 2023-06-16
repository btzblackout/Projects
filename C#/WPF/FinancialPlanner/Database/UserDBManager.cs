/*  
 * DBManager.cs
 * Author: Raymond Lawson
 */
using MySql.Data.MySqlClient;
using System.Windows;
namespace FinancialPlanner.Database
{
    class UserDBManager
    {
        //Declare variables.
        private string username;
        private string password;
        private string sql;
        private MySqlCommand command;
        private Connection connection;

        //Constructor.
        public UserDBManager(string username, string password)
        {
            this.username = username;
            this.password = password;
            this.connection = new Connection();
            this.command = new MySqlCommand(sql, connection.GetConnection());

        }

        //READ
        public bool CheckIfUserExists(string condition)
        {
            //Two conditions to determin if checking the username with the password or without.
            if(condition== "without")
            {
                this.sql = $"SELECT username FROM users WHERE username = '" + this.username + "'";
            }
            else
            {
                this.sql = $"SELECT username FROM users WHERE username = '" + this.username + "' AND password ='" + this.password + "'";
            }
            
            //Open the connection.
            if(connection.OpenConnection())
            {
                try
                {
                    //Set the CommandText and run an ExecuteScalar().
                    command.CommandText = this.sql;
                    object a = command.ExecuteScalar();

                    //If the ExecuteScalar() returned anything it means it was able to find a match.
                    //So if it is null there was no user found.
                    if(a == null)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                catch(MySqlException e)
                {
                    MessageBox.Show("" + e);
                }
            }
            //Close the connection.
            connection.CloseConnection();
            return false;
        }

        //CREATE
        public bool AddUser()
        {
            //Ensure the username and password aren't null.
            if(!string.IsNullOrEmpty(this.username) && !string.IsNullOrEmpty(this.password))
            {
                try
                {
                    //Check to see if the user exists before trying to add them.
                    if(!CheckIfUserExists("without"))
                    {
                        //Open the connection.
                        if(connection.OpenConnection())
                        {
                            //Set the correct SQL statement to add the user, update the CommandText, run the ExecuteNonQuery, and close the connection.
                            this.sql = $"INSERT INTO users (username, password) VALUES ('" + username + "', '" + password + "')";
                            command.CommandText = this.sql;
                            command.ExecuteNonQuery();
                            connection.CloseConnection();
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                catch(MySqlException e)
                {
                    MessageBox.Show("" + e);
                }                              
                return false;
            }
            else
            {
                return false;
            }

        }

    }
}
