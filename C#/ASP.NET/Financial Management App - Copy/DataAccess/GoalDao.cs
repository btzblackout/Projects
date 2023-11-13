using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Financial_Management_App.Models;
namespace Financial_Management_App.DataAccess
{
    interface GoalDao
    {
        public List<Goal>ReturnGoalList(User user);
        public void AddGoal(Goal goal);
        public bool UpdateGoal(Goal goal);
        public bool DeleteGoal(Goal goal);
    }
}
