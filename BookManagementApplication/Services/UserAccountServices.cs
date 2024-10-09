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

        public void AddUser(UserAccount user)
        {
            int userId = userRepo.GetUserAccountPrimaryKey();
            user.MemberId = userId + 1;
            userRepo.AddUserToDB(user);
        }

        public List<UserAccount> GetAllUserAccount() => userRepo.GetUserAllAccountsInDB();

        public UserAccount? LoginAccount(string userName, string password) => userRepo.GetUserAccountInDB(userName, password);

        public void RemoveUser(UserAccount userAccount)
        {
            userRepo.RemoveUserAccountInDB(userAccount);
        }

        public void RemoveUserAccount(int userId)
        {
            UserAccount? removeUser = userRepo.SearchUserAccountInDB(userId);
            if (removeUser != null)
            {
                userRepo.RemoveUserAccountInDB(removeUser);
            }
        }

        public void RemoveUserAccount(string userName)
        {
            UserAccount? removeUser = userRepo.SearchUserAccountInDB(userName);
            if (removeUser != null)
            {
                userRepo.RemoveUserAccountInDB(removeUser);
            }
        }
    }
}
