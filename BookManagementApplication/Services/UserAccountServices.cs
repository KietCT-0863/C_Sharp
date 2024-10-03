using Repositories;
using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class UserAccountServices
    {
        UserAccountRepository userRepo = new UserAccountRepository();

        //public GetUserAccountPrimaryKey

        public void AddUser(UserAccount user)
        {
            int userId = userRepo.GetUserAccountPrimaryKey();
            user.MemberId = userId + 1;
            userRepo.AddUserToDB(user);
        }

        public UserAccount? LoginAccount(string userName, string password) => userRepo.GetUserAccount(userName, password);
    }
}
