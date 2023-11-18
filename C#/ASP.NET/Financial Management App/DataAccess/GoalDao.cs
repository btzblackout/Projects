using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Financial_Management_App.Models;
namespace Financial_Management_App.DataAccess
{
    interface GoalDao
    {
        // Create
        public void AddGoal(Goal goal, User user);

        // Read
        public List<Goal> ReturnGoalList(User user);

        // Update
        public bool UpdateGoal(Goal goal, User user);

        // Delete
        public bool DeleteGoal(Goal goal, User user);
    }
}
