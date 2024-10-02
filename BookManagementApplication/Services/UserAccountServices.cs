﻿using Repositories;
using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class UserAccountServices
    {
        UserAccountRepository userRepo = new UserAccountRepository();

        public void AddUser(UserAccount user) => userRepo.AddUserToDB(user);
    }
}