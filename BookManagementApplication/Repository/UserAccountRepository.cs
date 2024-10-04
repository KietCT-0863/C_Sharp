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

        public int GetUserAccountPrimaryKey()
        {
            _context = new();
            return _context.UserAccounts.Max(u => u.MemberId);
        }

        public void AddUserToDB(UserAccount userAccount)
        {
            _context = new();
            _context.UserAccounts.Add(userAccount);
            _context.SaveChanges();
        }

        public UserAccount? GetUserAccount(string userName, string password)
        {
            _context = new();
            // Ternary Operator : toán tử ba ngôi
            return _context.UserAccounts.FirstOrDefault(userAccount => (userAccount.FullName == userName && userAccount.Password == password) ? true : false);
        }
    }
}
