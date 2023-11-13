using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Financial_Management_App.Models;
using Financial_Management_App.DataAccess;

namespace Financial_Management_App.BusinessLogic
{
    public class IncomeDateCalculate
    {
        IncomeDaoImp incomeDaoImp = new IncomeDaoImp();
        GoalDaoImp goalDaoImp = new GoalDaoImp();
        UserDaoImp userDaoImp = new UserDaoImp();
        public User CalculatePayEndDate(User user)
        {

            switch (user.IncomeList[0].Type)
            {
                case "Week":
                    {
                        // Set the last day of that pay period to 1 less
                        // because on the last day it will be the first day of your next paycheck
                        user.IncomeList[0].End_Date = user.IncomeList[0].Begin_Date.AddDays((user.IncomeList[0].Interval * 7) -1);
                        break;
                    }
                case "Month":
                    {
                        // Same as above, subtract one day to set the last day of
                        // the current pay period.
                        user.IncomeList[0].End_Date = user.IncomeList[0].Begin_Date.AddMonths(user.IncomeList[0].Interval);
                        user.IncomeList[0].End_Date = user.IncomeList[0].End_Date.AddDays(-1);
                        break;
                    }
                default:
                    break;
            }
            // Calculate the next pay begin date.
            user.IncomeList[0].Next_Pay_Begin = user.IncomeList[0].End_Date.AddDays(1);

            // Calculate the next pay end date.
            user.IncomeList[0] = CalculateNextPayEnd(user.IncomeList[0]);

            if(user.GoalList.Count != 0)
            {
                // Grab the users goals
                user.GoalList = goalDaoImp.ReturnGoalList(user);

                // Parse through the goals and deduct the amounts from the users balance, decrement the intervals.
                foreach (Goal goal in user.GoalList)
                {
                    user.Balance = user.Balance - goal.SavedAmount;
                    goal.NumOfPaychecks--;

                    // Save the goal
                    goalDaoImp.UpdateGoal(goal);
                }
            }
            


            // Save the user balance
            userDaoImp.UpdateBalance(user.ID, user.Balance);
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
                        income.Next_Pay_End = income.Next_Pay_Begin.AddMonths(income.Interval);
                        income.Next_Pay_End = income.Next_Pay_End.AddDays(-1);
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
