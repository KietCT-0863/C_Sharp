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
        public List<UserAccount> GetAllUser() => _listUser = _userRepo.GetUserAllInDB();
        public UserAccount? CheckUserNameExist(string userName)
        {
            _listUser = GetAllUser();
            return _listUser.FirstOrDefault(u => (u.FullName == userName) ? true : false);
        }
        public int GetNewUserId()
        {
            _listUser = GetAllUser();
            return _listUser.Max(u => u.MemberId) + 1;
        }
        public UserAccount? LoginAccount(string userName, string password)
        {
            _listUser = GetAllUser();
            return _listUser.FirstOrDefault(userAccount => (userAccount.FullName == userName && userAccount.Password == password) ? true : false);
        }
        public void RemoveUser(UserAccount userAccount) => _userRepo.RemoveUserInDB(userAccount);
        public void RemoveUser(int userId)
        {
            _listUser = GetAllUser();
            UserAccount? removeUser = _listUser.FirstOrDefault(u => u.MemberId == userId);
            if (removeUser != null)
            {
                _userRepo.RemoveUserInDB(removeUser);
            }
        }
        public void RemoveUser(string userName)
        {
            _listUser = GetAllUser();
            UserAccount? removeUser = _listUser.FirstOrDefault(u => u.FullName == userName);
            if (removeUser != null)
            {
                _userRepo.RemoveUserInDB(removeUser);
            }
        }
    }
}
