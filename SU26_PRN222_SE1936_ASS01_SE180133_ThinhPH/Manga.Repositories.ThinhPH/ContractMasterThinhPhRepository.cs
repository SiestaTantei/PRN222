using Manga.Entites.ThinhPH.Models;
using Manga.Repositories.ThinhPH.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Manga.Repositories.ThinhPH.DBContext;

namespace Manga.Repositories.ThinhPH
{
    public class ContractMasterThinhPhRepository : GenericRepository<ContractMasterThinhPh>
    {
        public ContractMasterThinhPhRepository(MangaFlow_ProContext context) => _context = context;
        public async Task<List<ContractMasterThinhPh>> GetAllsAsync()
        {
            return await _context.ContractMasterThinhPhs
                .Include(c => c.Series).Include(c => c.ContractAssetThinhPhs).Include(c => c.RoyaltyPaymentThinhPhs)
                .ToListAsync();
        }
        public async Task<ContractMasterThinhPh?> GetByIdAsync(int? id)
        {
            return await _context.ContractMasterThinhPhs
                .Include(c => c.Series).Include(c => c.ContractAssetThinhPhs).Include(c => c.RoyaltyPaymentThinhPhs)
                .FirstOrDefaultAsync(c => c.ContractIdThinhPh == id);
        }
        public async Task<List<ContractMasterThinhPh>> SearchAsync(int? seriesId, DateTime? fromDate, DateTime? toDate, bool? isExclusive)
        {
            return await _context.ContractMasterThinhPhs
                .Include(c => c.Series).Include(c => c.ContractAssetThinhPhs).Include(c => c.RoyaltyPaymentThinhPhs)
                .Where(c =>
                    (!seriesId.HasValue || c.SeriesId == seriesId.Value) &&
                    (!fromDate.HasValue || c.SignDate >= fromDate.Value) &&
                    (!toDate.HasValue || c.SignDate <= toDate.Value) &&
                    (!isExclusive.HasValue || c.IsExclusive == isExclusive.Value))
                .ToListAsync();
        }
        //public async ContractMasterThinhPh CreateAsync(ContractMasterThinhPh contract)
        //{
        //    _context.ContractMasterThinhPhs.Add(contract);
        //    await _context.SaveChangesAsync();
        //    return contract;
        //}
    }
}
