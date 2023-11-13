using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Financial_Management_App.Models
{
    public class User
    {
        // Declare variables /w Getters & Setters

        private int id;
        public int ID
        {
            get { return this.id; }
            set { this.id = value; }
        }

        private string username;
        
        [Required(ErrorMessage = "Username is required.")]
        [StringLength(45, MinimumLength = 5)]
        public string Username
        {
            get { return this.username; }
            set { this.username = value; }
        }

        private string password;
        [Required(ErrorMessage = "Password is required.")]
        [StringLength(15)]
        [RegularExpression("^((?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[^a-zA-Z0-9])).{8,}$", ErrorMessage = "Passwords must be at least 8 characters and contain an upper case (A-Z), lower case (a-z), number (0-9) and special character (e.g. !@#$%^&*)")]
        [DataType(DataType.Password)]
        public string Password
        {
            get { return this.password; }
            set { this.password = value; }
        }

        private string first_name;

        [Required(ErrorMessage ="First name is required.")]
        public string First_Name
        {
            get { return this.first_name; }
            set { this.first_name = value; }
        }

        private string last_name;

        [Required(ErrorMessage = "Last name is required.")]
        public string Last_Name
        {
            get { return this.last_name; }
            set { this.last_name = value; }
        }

        private Decimal balance;
        public Decimal Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }

        private List<Expense> expenseList;
        public List<Expense> ExpenseList
        {
            get { return this.expenseList; }
            set { this.expenseList = value; }
        }

        private List<Income> incomeList;
        public List<Income> IncomeList
        {
            get { return this.incomeList; }
            set { this.incomeList = value; }
        }

        private List<Expense> currentPayPeriodExpenses;
        public List<Expense> CurrentPayPeriodExpenses
        {
            get { return this.currentPayPeriodExpenses; }
            set { this.currentPayPeriodExpenses = value; }
        }

        private List<Expense> nextPayPeriodExpenses;
        public List<Expense> NextPayPeriodExpenses
        {
            get { return this.nextPayPeriodExpenses; }
            set { this.nextPayPeriodExpenses = value; }
        }

        private List<Goal> goalList;

        public List<Goal> GoalList
        {
            get { return goalList; }
            set { goalList = value; }
        }



        // Create constructors
        public User(int id, string username, string password, string first_name, string last_name, Decimal balance)
        {
            this.id = id;
            this.username = username;
            this.password = password;
            this.first_name = first_name;
            this.last_name = last_name;
            this.balance = balance;
            this.expenseList = new List<Expense>();
            this.incomeList = new List<Income>();
            this.currentPayPeriodExpenses = new List<Expense>();
            this.nextPayPeriodExpenses = new List<Expense>();
            this.goalList = new List<Goal>();
        }

        public User()
        {
            this.expenseList = new List<Expense>();
            this.incomeList = new List<Income>();
            this.currentPayPeriodExpenses = new List<Expense>();
            this.nextPayPeriodExpenses = new List<Expense>();
            this.goalList = new List<Goal>();
        }


    }
}
