using Manga.Entites.ThinhPH.Models;
using Manga.Repositories.ThinhPH.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manga.Repositories.ThinhPH
{
    public class SystemUserAccountRepository : GenericRepository<SystemUserAccount>
    {
        public SystemUserAccountRepository() { }
        public SystemUserAccountRepository(MangaFlow_ProContext context) => _context = context;
        public async Task<List<SystemUserAccount>> GetAllUsersAsync()
        {
            return await _context.SystemUserAccounts.ToListAsync();
        }
        public async Task<SystemUserAccount> GetUserAsync(string userName, string password)
        {
            return await _context.SystemUserAccounts.FirstOrDefaultAsync(c => c.UserName == userName && c.Password == password)
                 ?? new SystemUserAccount();

            //return await _context.SystemUserAccounts.FirstOrDefaultAsync(c => c.UserName == user_name && c.Password == password)
            //     ?? new SystemUserAccount();

            //return await _context.SystemUserAccounts.FirstOrDefaultAsync(c => c.UserName == user_name && c.Password == password)
            //     ?? new SystemUserAccount();

            //return await _context.SystemUserAccounts.FirstOrDefaultAsync(c => c.UserName == user_name && c.Password == password)
            //     ?? new SystemUserAccount();
        }

        public async Task<SystemUserAccount?> GetUserByEmailAsync(string email)
        {
            // Simple, clean data retrieval
            return await _context.SystemUserAccounts
                                 .FirstOrDefaultAsync(u => u.Email == email);
        }
    }
}
