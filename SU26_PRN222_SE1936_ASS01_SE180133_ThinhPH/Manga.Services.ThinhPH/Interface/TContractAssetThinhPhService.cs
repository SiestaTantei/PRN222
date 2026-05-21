using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manga.Services.ThinhPH.Interface
{
    public interface TContractAssetThinhPhService
    {
        public Task<Entites.ThinhPH.Models.ContractAssetThinhPh> GetAllAssetsAsync();
        public Task<List<Entites.ThinhPH.Models.ContractAssetThinhPh>> GetAssetsByContractIdAsync(int contractIdThinhPh);
        public Task<int> CreateAsync(Entites.ThinhPH.Models.ContractAssetThinhPh asset);
        public Task<int> UpdateAsync(Entites.ThinhPH.Models.ContractAssetThinhPh asset);
        public Task<bool> RemoveAsync(int? id);
    }
}
