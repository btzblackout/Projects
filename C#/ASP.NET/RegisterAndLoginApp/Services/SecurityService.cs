﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RegisterAndLoginApp.Models;

namespace RegisterAndLoginApp.Services
{
    public class SecurityService
    {
        SecurityDAO securityDAO = new SecurityDAO();

        public bool IsValid(UserModel user)
        {
            return securityDAO.FindUserByNameAndPassword(user);
        }
    }
}
