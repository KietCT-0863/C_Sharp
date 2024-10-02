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

        public List<UserAccount> GetUserAccounts()
        {
            _context = new ();
            return _context.UserAccounts.ToList();
        }

        public void AddUserToDB(UserAccount userAccount)
        {
            _context = new();
            _context.UserAccounts.Add(userAccount);
            _context.SaveChanges();
        }
    }
}
