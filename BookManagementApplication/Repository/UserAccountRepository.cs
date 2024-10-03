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
        BookManagementDbContext _context;

        

        public void AddUserToDB(UserAccount userAccount)
        {
            _context = new();
            _context.UserAccounts.Add(userAccount);
            _context.SaveChanges();
        }

        public List<UserAccount> GetUserAccountsFromDB()
        {
            _context = new();
            return _context.UserAccounts.ToList();
        }

        public int GetUserAccountPrimaryKey()
        {
            _context = new();
            return _context.UserAccounts.Max(u => u.MemberId);
        }
    }
}
