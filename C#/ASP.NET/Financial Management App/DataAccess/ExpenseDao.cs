using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Financial_Management_App.Models;

namespace Financial_Management_App.DataAccess
{
    public interface ExpenseDao
    {
        public List<Expense> ReturnExpenseList(User user);

        public User AddExpense(Expense expense, User user);

        public void RemoveExpense(int expenseId, User user);

        public User EditExpense(Expense expense, User user);
    }
}
