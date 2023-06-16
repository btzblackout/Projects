/*  
 * Connection.cs
 * Author: Raymond Lawson
 */
using MySql.Data.MySqlClient;
using System.Windows;

namespace FinancialPlanner.Database
{
    public class Connection
    {
        //Declare variables.
        private MySqlConnection conn;
        private string server;
        private string user;
        private string pass;
        private string db;

        //Constructor.
        public Connection()
        {
            Initialize();
        }

        //Initialization.
        private void Initialize()
        {
            server = "localhost";
            db = "financial_app";
            user = "root";
            pass = "root";
            string connectionString;
            connectionString = "Data Source=" +  server + ";Database=" + db + ";User Id=" + user + ";Password=" + pass + ";SSL Mode=0";
            conn = new MySqlConnection(connectionString);
        }

        //Method to open the connection.
        public bool OpenConnection()
        {
            try
            {
                //Check  if the connection is already open. If so, close it.
                if (this.conn != null && this.conn.State != System.Data.ConnectionState.Closed)
                {
                    this.conn.Close();
                }

                this.conn.Open();
                return true;
            }
            catch(MySqlException e)
            {
                switch(e.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.");
                        break;
                    case 1045:
                        MessageBox.Show("Invalid Username/Password, please try again!");
                        break;
                    default:
                        MessageBox.Show("Unknown Error");
                        break;
                }
                return false;
            }
        }

        //Method to close the connection.
        public void CloseConnection()
        {
            this.conn.Close();
        }

        //Method to return the current connection.
        public MySqlConnection GetConnection()
        {
            return this.conn;
        }
    }
}
