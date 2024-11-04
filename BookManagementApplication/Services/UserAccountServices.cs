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
        private UserAccountRepository _userRepo = new UserAccountRepository();
        private List<UserAccount> _listUser = null;

        public void AddUser(UserAccount user)
        {
            user.MemberId = GetNewUserId();
            _userRepo.AddUserToDB(user);
        }

        public List<UserAccount> GetAllUser() => _listUser = _userRepo.GetAllUserInDB();

        public UserAccount? CheckUserExist(string userEmail)
        {
            _listUser = GetAllUser();
            return _listUser.FirstOrDefault(u => (u.Email == userEmail));
        }

        public int GetNewUserId()
        {
            _listUser = GetAllUser();
            return _listUser.Max(u => u.MemberId) + 1;
        }

        public UserAccount? LoginAccount(string userEmail, string userPassword)
        {
            return _userRepo.GetOneUserInDb(userEmail, userPassword);
        }

        public void RemoveUser(UserAccount userAccount) => _userRepo.RemoveUserInDB(userAccount);

        public void RemoveUser(int userId)
        {
            UserAccount? removeUser = _userRepo.GetUserById(userId);

            if (removeUser != null)
            {
                _userRepo.RemoveUserInDB(removeUser);
            }
        }

        public void RemoveUser(string userName)
        {
            UserAccount? removeUser = _userRepo.GetUserByName(userName);

            if (removeUser != null)
            {
                _userRepo.RemoveUserInDB(removeUser);
            }
        }
    }
}
