using Manga.Entites.ThinhPH.Models;
using Manga.Repositories.ThinhPH.DBContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manga.Repositories.ThinhPH
{
    public class RoyaltyPaymentThinhPhRepository : Base.GenericRepository<Entites.ThinhPH.Models.RoyaltyPaymentThinhPh>
    {
        public RoyaltyPaymentThinhPhRepository() { }
        public RoyaltyPaymentThinhPhRepository(MangaFlow_ProContext context) => _context = context;
        public async Task<List<Entites.ThinhPH.Models.RoyaltyPaymentThinhPh>> GetAllPaymentAsync()
        {
           return await _context.RoyaltyPaymentThinhPhs.ToListAsync();
        }
        public async Task<Entites.ThinhPH.Models.RoyaltyPaymentThinhPh> GetPaymentsByContractIdAsync(int? contractIdThinhPh)
        {
           return await _context.RoyaltyPaymentThinhPhs
                .FirstOrDefaultAsync(p => p.ContractIdThinhPh == contractIdThinhPh) ?? new Entites.ThinhPH.Models.RoyaltyPaymentThinhPh();
        }
        public async Task<List<Entites.ThinhPH.Models.RoyaltyPaymentThinhPh>> GetPaymentsByDateRangeAsync(DateTime fromDate, DateTime toDate)
        {
            return await _context.RoyaltyPaymentThinhPhs
                .Where(p => p.PaymentDate >= fromDate && p.PaymentDate <= toDate)
                .ToListAsync();
        }
    }
}
