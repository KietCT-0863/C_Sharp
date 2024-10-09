using Microsoft.EntityFrameworkCore.Migrations.Operations;
using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class UserAccountRepository
    {
        BookManagementDbContext? _context;

        public int GetUserAccountMaxPrimaryKey()
        {
            _context = new();
            return _context.UserAccounts.Max(u => u.MemberId);
        }

        public List<UserAccount> GetUserAllAccountsInDB()
        {
            _context = new();
            return _context.UserAccounts.ToList();
        }

        public void AddUserToDB(UserAccount userAccount)
        {
            _context = new();
            _context.UserAccounts.Add(userAccount);
            _context.SaveChanges();
        }

        public UserAccount? GetUserAccountInDB(string userName, string password)
        {
            _context = new();
            return _context.UserAccounts.FirstOrDefault(userAccount => (userAccount.FullName == userName && userAccount.Password == password) ? true : false);
        }

        public void RemoveUserAccountInDB(UserAccount userAccount)
        {
            _context = new();
            _context.UserAccounts.Remove(userAccount);
            _context.SaveChanges();
        }

        public UserAccount? SearchUserAccountInDB(int userId)
        {
            _context = new();
            return _context.UserAccounts.FirstOrDefault(u => u.MemberId == userId);
        }

        public UserAccount? SearchUserAccountInDB(string userName)
        {
            _context = new();
            return _context.UserAccounts.FirstOrDefault(u => u.FullName == userName);
        }
    }
}
