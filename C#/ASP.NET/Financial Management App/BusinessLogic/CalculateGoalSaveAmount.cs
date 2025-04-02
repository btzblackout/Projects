using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Financial_Management_App.Models;
using Microsoft.Extensions.Configuration;
namespace Financial_Management_App.BusinessLogic
{
    public class CalculateGoalSaveAmount
    {
        private readonly IncomeDateCalculate incomeDateCalculate;

        public CalculateGoalSaveAmount(IConfiguration configuration)
        {
            incomeDateCalculate = new IncomeDateCalculate(configuration);
        }
        
        // Calculate the amount to save based on the date.
        public Goal CalculateSaveAmountForDate(Goal goal, User user)
        {
            if (!user.IncomeList.Any()) return goal;
            // determine how many paychecks the user has between now and goal date.
            goal.NumOfPaychecks = CalculatePaychecks(user, goal);

            // Avoid divide by 0
            if(goal.NumOfPaychecks > 0)
            {
                // Take the goal amount and divide it evenly among the paychecks.
                goal.SavedAmount = goal.Price / goal.NumOfPaychecks;
            }
            else
            {
                goal.SavedAmount = goal.Price;
            }


                return goal;
        }

        // Calculate the amount to save based on the priority.
        public Goal CalculateSaveAmountForPriority(Goal goal, User user)
        {
            if (!user.IncomeList.Any()) return goal;
            
            decimal savePortion = 0;
            // Determine percent amount from priority
            switch(goal.Priority)
            {
                case 1:
                    {
                        // This is low priority - 10% of income per pay period.
                        savePortion = user.IncomeList[0].Amount * (decimal)0.1m;
                        break;
                    }
                case 2:
                    {
                        // This is medium priority - 20% of income per pay period.
                        savePortion = user.IncomeList[0].Amount * (decimal)0.2m;
                        break;
                    }
                case 3:
                    {
                        // This is high priority - 30% of income per pay period.
                        savePortion = user.IncomeList[0].Amount * (decimal)0.3m;
                        break;
                    }
                default:
                    break;
            }

            // Check if the amount to save is more than the original price.
            if(savePortion >= goal.Price)
            {
                goal.SavedAmount = goal.Price;
            }
            else
            {
                goal.SavedAmount = savePortion;
                goal.NumOfPaychecks = (int)Math.Ceiling(goal.Price / savePortion);
            }

            // Calculate the number of paychecks it will take at this number.
            return goal;
        }

        private int CalculatePaychecks(User user, Goal goal)
        {
            // Create counter
            int counter = 0;

            if (user.IncomeList.Any()) return counter;
            // Create a dummy income object to perform the calculations on.
            User dummyUser = new User { IncomeList = new List<Income> { new Income()} };

            // Set the values like this instead of income = user.incomeList[0] to avoid linking the two.
            dummyUser.IncomeList[0].Begin_Date = user.IncomeList[0].Begin_Date;
            dummyUser.IncomeList[0].Interval = user.IncomeList[0].Interval;
            dummyUser.IncomeList[0].Type = user.IncomeList[0].Type;
            
            // While the beginning of the pay is less than the goals date.
            while(dummyUser.IncomeList[0].Begin_Date < goal.Date)
            {
                // Increment the counter and pay.
                counter ++;
                dummyUser = incomeDateCalculate.CalculatePayEndDate(dummyUser);

                // Increase income begin date.
                dummyUser.IncomeList[0].Begin_Date = dummyUser.IncomeList[0].End_Date.AddDays(1);

            }

            // Return the counter number
            return counter;
        }
    }
}
