using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Financial_Management_App.Models;
using Financial_Management_App.DataAccess;
using Microsoft.Extensions.Configuration;

namespace Financial_Management_App.BusinessLogic
{
    public class IncomeDateCalculate
    {
        private readonly IncomeDao incomeDao;
        private readonly GoalDao goalDao;
        private readonly UserDao userDao;

        public IncomeDateCalculate(IConfiguration configuration)
        {
            incomeDao = new IncomeDaoImp(configuration);
            userDao = new UserDaoImp(configuration);
            goalDao = new GoalDaoImp(configuration);
        }

        public User CalculatePayEndDate(User user)
        {
            if (!user.IncomeList.Any()) return user;

            Income income = user.IncomeList[0];
            switch (income.Type)
            {
                case "Week":
                    {
                        // Set the last day of that pay period to 1 less
                        // because on the last day it will be the first day of your next paycheck
                        income.End_Date = income.Begin_Date.AddDays((income.Interval * 7) - 1);
                        break;
                    }
                case "Month":
                    {
                        // Same as above, subtract one day to set the last day of
                        // the current pay period.
                        income.End_Date = income.Begin_Date.AddMonths(income.Interval).AddDays(-1);
                        break;
                    }
                default:
                    break;
            }
            // Calculate the next pay begin date.
            income.Next_Pay_Begin = income.End_Date.AddDays(1);

            // Calculate the next pay end date.
            income = CalculateNextPayEnd(income);

            // Save the updated income to DB
            incomeDao.UpdateIncome(income, user);

            if(user.GoalList.Any())
            {
                // Grab the users goals
                user.GoalList = goalDao.ReturnGoalList(user);

                // Parse through the goals and deduct the amounts from the users balance, decrement the intervals.
                foreach (Goal goal in user.GoalList)
                {
                    user.Balance -= goal.SavedAmount;
                    goal.NumOfPaychecks--;

                    // Save the goal
                    goalDao.UpdateGoal(goal, user);
                }
            }
            


            // Save the user balance
            userDao.UpdateBalance(user.ID, user.Balance, user);
            // Return the income.
            return user;
        }

        
        private Income CalculateNextPayEnd(Income income)
        {
            // Determine the interval type.
            switch(income.Type)
            {
                case "Week":
                    {
                        // Add the number of weeks, minus 1 day.
                        income.Next_Pay_End = income.Next_Pay_Begin.AddDays((income.Interval * 7) - 1);
                        break;
                    }
                case "Month":
                    {
                        // Add the number of months, minus 1 day. 
                        income.Next_Pay_End = income.Next_Pay_Begin.AddMonths(income.Interval).AddDays(-1);
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
                                
            return income;

        }
    }

}
