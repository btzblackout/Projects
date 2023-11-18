using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Financial_Management_App.Models;

namespace Financial_Management_App.DataAccess
{
    public interface ExpenseDao
    {
        // Create
        public User AddExpense(Expense expense, User user);

        // Read
        public List<Expense> ReturnExpenseList(User user);

        // Update
        public User EditExpense(Expense expense, User user);

        // Delete
        public void DeleteExpense(int expenseId, User user);

        // Prevent duplicate expense names.
        public bool CheckForExistingExpense(Expense expense, User user);
    }
}
