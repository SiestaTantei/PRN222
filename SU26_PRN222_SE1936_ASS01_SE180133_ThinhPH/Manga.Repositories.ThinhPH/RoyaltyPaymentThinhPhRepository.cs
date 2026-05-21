using Manga.Entites.ThinhPH.Models;
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
        public async Task<Entites.ThinhPH.Models.RoyaltyPaymentThinhPh> GetAllPaymentAsync()
        {
            return await _context.RoyaltyPaymentThinhPhs.FirstOrDefaultAsync() ?? new Entites.ThinhPH.Models.RoyaltyPaymentThinhPh();
        }
        public async Task<List<Entites.ThinhPH.Models.RoyaltyPaymentThinhPh>> GetPaymentsByContractIdAsync(int contractIdThinhPh)
        {
            return await _context.RoyaltyPaymentThinhPhs
                .Where(p => p.ContractIdThinhPh == contractIdThinhPh)
                .ToListAsync();
        }
        public async Task<List<Entites.ThinhPH.Models.RoyaltyPaymentThinhPh>> GetPaymentsByDateRangeAsync(DateTime fromDate, DateTime toDate)
        {
            return await _context.RoyaltyPaymentThinhPhs
                .Where(p => p.PaymentDate >= fromDate && p.PaymentDate <= toDate)
                .ToListAsync();
        }
    }
}
