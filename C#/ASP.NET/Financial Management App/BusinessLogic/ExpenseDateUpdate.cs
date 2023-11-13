using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Financial_Management_App.Models;
using Financial_Management_App.DataAccess;

namespace Financial_Management_App.BusinessLogic
{
    public class ExpenseDateUpdate
    {
        IncomeDateCalculate incomeDateCalculate = new IncomeDateCalculate();

        public User Update (User user)
        {
            // Get a fresh, updated list
            ExpenseDaoImp expenseDaoImp = new ExpenseDaoImp();
            UserDaoImp userDaoImp = new UserDaoImp();
            IncomeDaoImp incomeDaoImp = new IncomeDaoImp();

            user.ExpenseList = expenseDaoImp.ReturnExpenseList(user);
            user.IncomeList = incomeDaoImp.ReturnIncomeList(user);
            // Parse through the list
            foreach (Expense expense in user.ExpenseList)
            {
                // Compare the expense date to the current date, while it is less, increment based on interval and type of interval.
                while(expense.Date.Date <= DateTime.Now.Date)
                {
                    // Deduce from the balance
                    user.Balance = user.Balance - expense.Price;

                    // The date has passed, update the expense's new due date
                    switch (expense.Type)
                    {
                        case "Day":
                            {
                                expense.Date = expense.Date.AddDays(expense.Interval);
                                break;
                            }
                        case "Week":
                            {
                                expense.Date = expense.Date.AddDays(expense.Interval * 7);
                                break;
                            }
                        case "Month":
                            {
                                expense.Date = expense.Date.AddMonths(expense.Interval); 
                                break;
                            }
                        case "Year":
                            {
                                expense.Date = expense.Date.AddYears(expense.Interval);
                                break;
                            }
                        default:
                            break;
                    }

                    // Save the new expense in the Database.
                    expenseDaoImp.EditExpense(expense, user);

                    // Save the updated balance
                    userDaoImp.UpdateBalance(user.ID, user.Balance);
                }

            }

            // Update current and next pay period dates.
            if(user.IncomeList.Count != 0)
            {
                // If the first day of the next pay is today or in the past.
                if(user.IncomeList[0].Next_Pay_Begin <= DateTime.Now)
                {
                    // Repeat until the paycheck is current.
                    while(user.IncomeList[0].Begin_Date < DateTime.Now)
                    {
                        // Update the new begin date.
                        user.IncomeList[0].Begin_Date = user.IncomeList[0].End_Date.AddDays(1);

                        // Call to update the income dates.
                        user = incomeDateCalculate.CalculatePayEndDate(user);
                    }

                    
                }
            }
            
            // Set the users current pay period list
            user.CurrentPayPeriodExpenses = UpdateCurrentPayPeriod(user).OrderBy(expense=>expense.Date).ToList();

            // Set the users next pay period list
            user.NextPayPeriodExpenses = UpdateNextPayPeriod(user).OrderBy(expense => expense.Date).ToList();

            // Return the user.
            return user;
        }

        private List<Expense> UpdateCurrentPayPeriod(User user)
        {
            List<Expense> currentPayPeriod = new List<Expense>();
            // Check if the users income list is empty, if so then don't attempt to set current or next pay period.
            if(user.IncomeList.Count != 0)
            {
                foreach (Expense expense in user.ExpenseList)
                {
                    // If the expense is today or in the future.
                    if (expense.Date >= user.IncomeList[0].Begin_Date && expense.Date <= user.IncomeList[0].End_Date)
                    {
                        // Add the expense to the currentPayPeriod list.
                        currentPayPeriod.Add(expense);
                    }
                }

                return currentPayPeriod;
            }
            // The user has not added income, or has deleted their income.
            // Return the expense list so it is displayed instead until the user adds an income.
            else
            {
                return user.ExpenseList;
            }
        }

        private List<Expense> UpdateNextPayPeriod(User user)
        {
            List<Expense> nextPayPeriod = new List<Expense>();
            
            
            // Check if the users income list is empty, if so then don't attempt to set current or next pay period.
            if (user.IncomeList.Count != 0)
            {
                // If the expense is between the beginning and end of next pay period.
                foreach(Expense expense in user.ExpenseList)
                {
                    if(expense.Date >= user.IncomeList[0].Next_Pay_Begin && expense.Date <= user.IncomeList[0].Next_Pay_End)
                    {
                        // Add the expense to the currentPayPeriod list.
                        nextPayPeriod.Add(expense);
                    }
                }

                return nextPayPeriod;
            }
            // The user has not added income, or has deleted their income.
            // Return the expense list so it is displayed instead until the user adds an income.
            else
            {
                return user.ExpenseList;
            }
        }
    }
}
