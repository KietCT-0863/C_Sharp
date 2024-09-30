using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    internal class UserAccountRepository
    {
        BookManagementDbContext _context;
        public List<UserAccount> GetUserAccounts()
        {
            _context = new ();
            return _context.UserAccounts.ToList();
        }
    }
}
