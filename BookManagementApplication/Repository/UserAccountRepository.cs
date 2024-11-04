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

        public void AddUserToDB(UserAccount userAccount)
        {
            _context = new();
            _context.UserAccounts.Add(userAccount);
            _context.SaveChanges();
        }

        public List<UserAccount> GetAllUserInDB()
        {
            _context = new();
            return _context.UserAccounts.ToList();
        }

        public void RemoveUserInDB(UserAccount userAccount)
        {
            _context = new();
            _context.UserAccounts.Remove(userAccount);
            _context.SaveChanges();
        }

        public UserAccount? GetOneUserInDb(string userEmail, string userPassword)
        {
            _context = new();
            return _context.UserAccounts.FirstOrDefault(u => u.Email.ToLower() == userEmail.ToLower() && u.Password == userPassword);
        }

        public UserAccount? GetUserById(int userId)
        {
            _context = new();
            return _context.UserAccounts.FirstOrDefault(u => u.MemberId == userId);
        }

        public UserAccount? GetUserByName(string userName)
        {
            _context = new();
            return _context.UserAccounts.FirstOrDefault(u => u.FullName == userName);
        }
    }
}
