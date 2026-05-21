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
    public class ContractAssetThinhPhRepository : GenericRepository<Entites.ThinhPH.Models.ContractAssetThinhPh>
    {
        public ContractAssetThinhPhRepository() { }
        public ContractAssetThinhPhRepository(MangaFlow_ProContext context) => _context = context;
        public async Task<Entites.ThinhPH.Models.ContractAssetThinhPh> GetAllAssetsAsync()
        {
            return await _context.ContractAssetThinhPhs.FirstOrDefaultAsync() ?? new Entites.ThinhPH.Models.ContractAssetThinhPh();
        }

        public async Task<List<Entites.ThinhPH.Models.ContractAssetThinhPh>> GetAssetsByContractIdAsync(int contractIdThinhPh)
        {
            return await _context.ContractAssetThinhPhs
                .Where(a => a.ContractIdThinhPh == contractIdThinhPh)
                .ToListAsync();
        }
    }
}
