using Financial_Management_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySqlConnector;
using Financial_Management_App.BusinessLogic;

namespace Financial_Management_App.DataAccess
{
    public class IncomeDaoImp : IncomeDao
    {      
        // Create
        public void AddIncome(Income income, User user)
        {
            // Add the income to the DB
            DBConnection("INSERT INTO income (Name, Amount, Begin_Date, End_Date, `Interval`, Type, Next_Pay_Begin, Next_Pay_End, Notes, UserID) VALUES ('" + income.Name + "', " + income.Amount + ", '" + income.Begin_Date.ToString("yyyy-MM-dd") + "', '" + income.End_Date.ToString("yyyy-MM-dd") + "', " + income.Interval + ", '" + income.Type + "', '" + income.Next_Pay_Begin.ToString("yyyy-MM-dd") + "', '" + income.Next_Pay_End.ToString("yyyy-MM-dd") + "', '"+ income.Notes + "', " + income.UserId + ")");
        
        }

        // Read
        public List<Income> ReturnIncomeList(User user)
        {
            return DBConnection("SELECT * FROM income WHERE UserID = '" + user.ID + "'");
        }

        // Update
        public bool UpdateIncome(Income income)
        {
            // Update the record.
            List<Income> incomeList = DBConnection("UPDATE income SET Name = '" + income.Name + "', Amount = " + income.Amount + ", Begin_Date = '" + income.Begin_Date.ToString("yyyy-MM-dd") + "', End_Date = '" + income.End_Date.ToString("yyyy-MM-dd") + "', `Interval` = " + income.Interval + ", Type = '" + income.Type + "', Next_Pay_Begin = '" + income.Next_Pay_Begin.ToString("yyyy-MM-dd") + "', Next_Pay_End = '" + income.Next_Pay_End.ToString("yyyy-MM-dd") + "', Notes = '" + income.Notes + "' WHERE ID = " + income.ID);
            return true;
        }

        // Delete
        public bool DeleteIncome(Income income)
        {
            // Create a blank user to hold the returned list
            User user = new User();

            // Attempt to remove the income;
            user.IncomeList = DBConnection("DELETE FROM income WHERE ID = " + income.ID);

            // Check if the list is empty.
            if (user.IncomeList.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Check if username exists.
        public bool CheckIncomeName(Income income, User user)
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
            command.CommandText = "SELECT * FROM income WHERE Name = '" + income.Name + "' AND UserID = " + user.ID;

            // If ExecureScalar is Null the income name does not exist.
            if(command.ExecuteScalar() == null)
            {
                exists = false;
            }

            // Close the connection.
            connection.Close();

            return exists;
        }

        // Connection method.
        private List<Income> DBConnection(string statement)
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder
            {
                Server = "localhost",
                UserID = "root",
                Password = "root",
                Database = "financial_management"
            };

            List<Income> incomeList = new List<Income>();

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
                var amount = reader.GetDecimal("Amount");
                var begin_date = reader.GetDateTime("Begin_Date");
                var end_date = reader.GetDateTime("End_Date");
                var interval = reader.GetByte("Interval");
                var type = reader.GetString("Type");
                var next_Pay_Begin = reader.GetDateTime("Next_Pay_Begin");
                var next_Pay_End = reader.GetDateTime("Next_Pay_End");
                var notes = reader.GetString("notes");
                var userId = reader.GetInt32("UserID");

                // Set the strings
                Income income = new Income(id, name, amount, begin_date, end_date, interval, type, next_Pay_Begin, next_Pay_End, notes, userId);
                income.Next_Pay_Begin_String = income.Next_Pay_Begin.ToString("d");
                income.Next_Pay_End_String = income.Next_Pay_End.ToString("d");
                incomeList.Add(income);
            }

            // Close the connection.
            connection.Close();
            return incomeList;
        }
    }
}
