using Financial_Management_App.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Financial_Management_App.DataAccess;
using Microsoft.AspNetCore.Http;
using Financial_Management_App.BusinessLogic;

namespace Financial_Management_App.Controllers
{
    public class HomeController : Controller
    {
        // Dao objects
        ExpenseDao expenseDao = new ExpenseDaoImp();
        UserDao userDao = new UserDaoImp();
        IncomeDao incomeDao = new IncomeDaoImp();
        GoalDao goalDao = new GoalDaoImp();

        // Model objects
        User currentUser = new User();

        // Business Logic objects
        ExpenseDateUpdate expenseDateUpdate = new ExpenseDateUpdate();
        IncomeDateCalculate incomeDateCalculate = new IncomeDateCalculate();
        CalculateGoalSaveAmount calculateGoalSaveAmount = new CalculateGoalSaveAmount();

        // Index Page
        public IActionResult Index()
        {
            // Ensure the user is logged in.
            if(UserLoggedInCheck())
            {
                // Get the session to ensure the user is logged in.
                string user = HttpContext.Session.GetString("username");

                // Grab the user from the DB.
                currentUser = userDao.CheckByUsername(user);

                // Call for the Expense date update.
                currentUser = expenseDateUpdate.Update(currentUser);

                // Call for the Income list update.
                currentUser.IncomeList = incomeDao.ReturnIncomeList(currentUser);


                // Call for the Goal list update
                currentUser.GoalList = goalDao.ReturnGoalList(currentUser);

                // Return the Home page and pass the current user.
                return View(currentUser);
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
            
        }

        // Balance
        public IActionResult EditBalance(User user)
        {
            if (UserLoggedInCheck())
            {
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
                
        }
        public IActionResult UpdateBalance(User user)
        {
            if(UserLoggedInCheck())
            {
                // Get the session to ensure the user is logged in.
                string userSession = HttpContext.Session.GetString("username");

                // Grab the user from the DB.
                currentUser = userDao.CheckByUsername(userSession);

                // TODO: see if currentuser is not needed here because User is passed.
                userDao.UpdateBalance(currentUser.ID, user.Balance, currentUser);
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
            
        }

        // Logout
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Login");
        }

        // Check for user logged in.
        private bool UserLoggedInCheck()
        {
            // Attempt to get the username from session
            string user = HttpContext.Session.GetString("username");
            if (user == null)
            {
                return false;
            }
            else
                return true;
        }

        // Expenses
        public IActionResult Expenses()
        {
            if(UserLoggedInCheck())
            {
                // Retrieve the username from active session.
                string user = HttpContext.Session.GetString("username");

                // Grab the user object.
                currentUser = userDao.CheckByUsername(user);

                // Call for the Expense date update.
                currentUser = expenseDateUpdate.Update(currentUser);

                return View(currentUser.ExpenseList);
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
            
        }
        public IActionResult AddExpense(Expense expense)
        {
            if(UserLoggedInCheck())
            {
                // The method is called from the Add Expense page
                if (expense.Name != null)
                {
                    if (ModelState.IsValid)
                    {
                        // Retrieve the username from active session.
                        string user = HttpContext.Session.GetString("username");

                        // Grab the user object.
                        currentUser = userDao.CheckByUsername(user);

                        // Populate missing parts of expense
                        expense.UserId = currentUser.ID;

                        // Check if the expense name already exists (true = exists, false = does not exist)
                        if (expenseDao.CheckForExistingExpense(expense, currentUser))
                        {
                            return View("ExpenseExists", expense);
                        }

                        // Add expense to users expense list
                        currentUser = expenseDao.AddExpense(expense, currentUser);

                        // Return to the expenses page.
                        return RedirectToAction("Expenses");
                    }
                    else
                    {
                        return View();
                    }

                }
                else
                {

                    return View();
                }
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }

        }
        public IActionResult DeleteExpense(Expense expense)
        {
            if(UserLoggedInCheck())
            {
                return View(expense);
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
            
        }
        public IActionResult ProcessDeleteExpense(Expense expense)
        {
            if(UserLoggedInCheck())
            {
                // Retrieve the username from active session.
                string user = HttpContext.Session.GetString("username");

                // Grab the user object.
                currentUser = userDao.CheckByUsername(user);

                // Process the deleteion of the expense.
                expenseDao.DeleteExpense(expense.ID, currentUser);

                return RedirectToAction("Expenses");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public IActionResult EditExpense(Expense expense)
        {
            if(UserLoggedInCheck())
            {
                return View(expense);
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
            
        }
        public IActionResult ProcessEditExpense(Expense expense)
        {
            if(UserLoggedInCheck())
            {
                if (ModelState.IsValid)
                {
                    // Retrieve the username from active session.
                    string user = HttpContext.Session.GetString("username");

                    // Grab the user object.
                    currentUser = userDao.CheckByUsername(user);

                    // Set the expense user id.
                    expense.UserId = currentUser.ID;

                    expenseDao.EditExpense(expense, currentUser);

                    return RedirectToAction("Expenses");

                }
                else
                {
                    return RedirectToAction("EditExpense", expense);
                }
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
            
        }

        // Income
        public IActionResult Income()
        {
            if(UserLoggedInCheck())
            {
                // Retrieve the username from active session.
                string user = HttpContext.Session.GetString("username");

                // Grab the user object.
                currentUser = userDao.CheckByUsername(user);

                // Grab the user's list of income.
                currentUser.IncomeList = incomeDao.ReturnIncomeList(currentUser);

                return View(currentUser);
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
            
        }
        public IActionResult AddIncome(Income income)
        {
            if(UserLoggedInCheck())
            {
                // Retrieve the username from active session.
                string user = HttpContext.Session.GetString("username");

                // Grab the user object.
                currentUser = userDao.CheckByUsername(user);

                // If the income name is not null then the button is clicked from addincome.
                if (income.Name != null)
                {
                    // Populate the missing userid
                    income.UserId = currentUser.ID;

                    // If true, the income name doesn't exist, otherwise the income name already exists.
                    if (!incomeDao.CheckIncomeName(income, currentUser))
                    {
                        // Add the income to the user
                        currentUser.IncomeList.Add(income);
                        // Call IncomeDateCalculate to calculate income dates.
                        currentUser = incomeDateCalculate.CalculatePayEndDate(currentUser);

                        // Save income to DB
                        incomeDao.AddIncome(currentUser.IncomeList[0], currentUser);

                        return RedirectToAction("Income");
                    }
                    else
                    {
                        // At the current stage this will never execute as the user cannot add more than one income.
                        return View("IncomeExists");
                    }
                }

                return View();
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public IActionResult DeleteIncome()
        {
            if(UserLoggedInCheck())
            {
                // Grab the users username
                string username = HttpContext.Session.GetString("username");

                // Grab the user object.
                currentUser = userDao.CheckByUsername(username);

                // Grab the income.
                currentUser.IncomeList = incomeDao.ReturnIncomeList(currentUser);
                return View(currentUser.IncomeList[0]);
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
            
        }
        public IActionResult ProcessDeleteIncome()
        {
            if(UserLoggedInCheck())
            {
                // Grab the username from the session.
                String username = HttpContext.Session.GetString("username");

                // Grab the user object.
                currentUser = userDao.CheckByUsername(username);

                // Grab the income list.
                currentUser.IncomeList = incomeDao.ReturnIncomeList(currentUser);

                // Grab the goals list.
                currentUser.GoalList = goalDao.ReturnGoalList(currentUser);

                if(currentUser.GoalList.Count == 0)
                {
                    // Remove the income.
                    if (incomeDao.DeleteIncome(currentUser.IncomeList[0], currentUser))
                    {
                        return RedirectToAction("Income");
                    }
                    else
                    {
                        return View("IncomeDeleteError");
                    }
                }
                else
                {
                    return View("IncomeDeleteError");
                }
                

            }
            else
            {
                return RedirectToAction("Index", "Login");
            }

        }
        public IActionResult EditIncome()
        {
            if(UserLoggedInCheck())
            {
                // Grab the users username
                string username = HttpContext.Session.GetString("username");

                // Grab the user object.
                currentUser = userDao.CheckByUsername(username);

                // Grab the income.
                currentUser.IncomeList = incomeDao.ReturnIncomeList(currentUser);

                return View(currentUser.IncomeList[0]);
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
            
        }
        public IActionResult ProcessEditIncome(Income income)
        {
            // Get the session to ensure the user is logged in.
            string userSession = HttpContext.Session.GetString("username");

            // Grab the user from the DB.
            currentUser = userDao.CheckByUsername(userSession);

            if (UserLoggedInCheck())
            {
                if (incomeDao.UpdateIncome(income, currentUser))
                {
                    return RedirectToAction("Income");
                }
                else
                {
                    return View("IncomeEditError");
                }
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
            
        }

        // Goals
        public IActionResult Goals()
        {
            if(UserLoggedInCheck())
            {
                // Retrieve the username from active session.
                string user = HttpContext.Session.GetString("username");

                // Grab the user object.
                currentUser = userDao.CheckByUsername(user);

                // Grab the users goal list.
                currentUser.GoalList = goalDao.ReturnGoalList(currentUser);

                // Grab the users income list.
                currentUser.IncomeList = incomeDao.ReturnIncomeList(currentUser);
                return View(currentUser);
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
            
        }
        public IActionResult AddGoal(Goal goal)
        {
            if(UserLoggedInCheck())
            {
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
            
        }
        public IActionResult ProcessAddGoal(Goal goal)
        {
            if(UserLoggedInCheck())
            {
                // Retrieve the username from active session.
                string user = HttpContext.Session.GetString("username");

                // Grab the user object.
                currentUser = userDao.CheckByUsername(user);

                // Grab the user income list.
                currentUser.IncomeList = incomeDao.ReturnIncomeList(currentUser);

                // Populate the goals userid.
                goal.UserID = currentUser.ID;

                // Check if the user selected priority or date
                if (goal.Priority == 0)
                {
                    // Selected Date
                    goal = calculateGoalSaveAmount.CalculateSaveAmountForDate(goal, currentUser);

                    // Save the goal.
                    goalDao.AddGoal(goal, currentUser);

                    // Call the goals page.
                    return RedirectToAction("Goals");
                }
                else
                {
                    // Selected priority
                    goal = calculateGoalSaveAmount.CalculateSaveAmountForPriority(goal, currentUser);

                    // Save the goal.
                    goalDao.AddGoal(goal, currentUser);

                    // Call the goals page.
                    return RedirectToAction("Goals");
                }
            }
            else
            {
                return View();
            }
            
        }
        public IActionResult EditGoal(Goal goal)
        {
            if(UserLoggedInCheck())
            {
                return View(goal);
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }

        }
        public IActionResult ProcessEditGoal(Goal goal)
        {
            if(UserLoggedInCheck())
            {
                // Retrieve the username from active session.
                string user = HttpContext.Session.GetString("username");

                // Grab the user object.
                currentUser = userDao.CheckByUsername(user);

                // Grab the user income list.
                currentUser.IncomeList = incomeDao.ReturnIncomeList(currentUser);

                // Populate the goals userid.
                goal.UserID = currentUser.ID;

                // Check if the user selected priority or date
                if (goal.Priority == 0)
                {
                    // Selected Date
                    goal = calculateGoalSaveAmount.CalculateSaveAmountForDate(goal, currentUser);

                    // Save the goal.
                    goalDao.UpdateGoal(goal, currentUser);

                    // Call the goals page.
                    return RedirectToAction("Goals");
                }
                else
                {
                    // Selected priority
                    goal = calculateGoalSaveAmount.CalculateSaveAmountForPriority(goal, currentUser);

                    // Save the goal.
                    goalDao.UpdateGoal(goal, currentUser);

                    // Call the goals page.
                    return RedirectToAction("Goals");
                }
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public IActionResult DeleteGoal(Goal goal)
        {
            if(UserLoggedInCheck())
            {
                return View(goal);
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
            
        }
        public IActionResult ProcessDeleteGoal(Goal goal)
        {
            if(UserLoggedInCheck())
            {
                // Get the session to ensure the user is logged in.
                string userSession = HttpContext.Session.GetString("username");

                // Grab the user from the DB.
                currentUser = userDao.CheckByUsername(userSession);

                // Process the deletion of the goal.
                goalDao.DeleteGoal(goal, currentUser);

                return RedirectToAction("Goals");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
    }
}
