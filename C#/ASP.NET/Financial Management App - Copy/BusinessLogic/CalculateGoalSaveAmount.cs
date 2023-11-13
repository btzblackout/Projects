using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Financial_Management_App.Models;
namespace Financial_Management_App.BusinessLogic
{
    public class CalculateGoalSaveAmount
    {
        IncomeDateCalculate incomeDateCalculate = new IncomeDateCalculate();
        
        // Calculate the amount to save based on the date.
        public Goal CalculateSaveAmountForDate(Goal goal, User user)
        {
            // determine how many paychecks the user has between now and goal date.
            goal.NumOfPaychecks = CalculatePaychecks(user, goal);

            // Take the goal amount and divide it evenly among the paychecks.
            goal.SavedAmount = goal.Price / goal.NumOfPaychecks;

            return goal;
        }

        // Calculate the amount to save based on the priority.
        public Goal CalculateSaveAmountForPriority(Goal goal, User user)
        {
            Decimal savePortion = 0;
            // Determine percent amount from priority
            switch(goal.Priority)
            {
                case 1:
                    {
                        // This is low priority - 10% of income per pay period.
                        savePortion = user.IncomeList[0].Amount * (decimal)0.1;
                        break;
                    }
                case 2:
                    {
                        // This is medium priority - 20% of income per pay period.
                        savePortion = user.IncomeList[0].Amount * (decimal)0.2;
                        break;
                    }
                case 3:
                    {
                        // This is high priority - 30% of income per pay period.
                        savePortion = user.IncomeList[0].Amount * (decimal)0.3;
                        break;
                    }
                default:
                    break;
            }
            goal.SavedAmount = savePortion;
            goal.NumOfPaychecks = (int)Math.Ceiling(goal.Price / savePortion);


            // Calculate the number of paychecks it will take at this number.
            return goal;
        }

        private int CalculatePaychecks(User user, Goal goal)
        {
            // Create counter
            int counter = 0;
            // Create a dummy income object to perform the calculations on.
            User dummyUser = new User();
            dummyUser.IncomeList.Add(new Income());

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
