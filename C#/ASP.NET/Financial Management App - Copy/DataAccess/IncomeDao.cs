﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Financial_Management_App.Models;

namespace Financial_Management_App.DataAccess
{
    interface IncomeDao
    {
        // Create
        public void AddIncome(Income income, User user);

        // Read
        public List<Income> ReturnIncomeList(User user);

        // Update
        public bool UpdateIncome(Income income);

        // Delete
        public bool DeleteIncome(Income income);
    }
}