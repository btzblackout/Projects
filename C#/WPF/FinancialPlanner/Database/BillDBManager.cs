using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows;
using FinancialPlanner.Models;


namespace FinancialPlanner.Database
{
    class BillDBManager
    {
        //Declare variables.
        private string name, notes = "", month;
        private int date;
        private double amount;
        private bool paid;
        private string sql;
        private MySqlCommand command;
        private Connection connection;

        //Constructors.
         public BillDBManager(string name, int date, double amount, bool paid, string notes, string month)
        {
            this.name = name;
            this.date = date;
            this.amount = amount;
            this.paid = paid;
            this.notes = notes;
            this.month = month;
            this.connection = new Connection();
            this.command = new MySqlCommand(sql, connection.GetConnection());
        }
        public BillDBManager(string name, int date, double amount, bool paid, string month)
        {
            this.name = name;
            this.date = date;
            this.amount = amount;
            this.paid = paid;
            this.month = month;
            this.connection = new Connection();
            this.command = new MySqlCommand(sql, connection.GetConnection());
        }

        //CREATE
        private void AddBill()
        {
            
            if(connection.OpenConnection())
            {
                try
                {
                    this.sql = $"INSERT INTO bills (name, date, amount, paid, notes, month) VALUES ('" + this.name + "', '" + this.date + "', '" + this.amount + "', '" + this.paid + "', '" + this.notes + "', '" + this.month + "')";
                    command.CommandText = this.sql;
                    command.ExecuteNonQuery();
                    connection.CloseConnection();
                }
                catch(MySqlException e)
                {
                    MessageBox.Show("" + e);
                }

            }
        }
    }
}
