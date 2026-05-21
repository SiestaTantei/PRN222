using Manga.Entites.ThinhPH.Models;
using Manga.Repositories.ThinhPH;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manga.Services.ThinhPH
{
    public class ContractAssetThinhPhService : Interface.TContractAssetThinhPhService
    {
        private readonly Repositories.ThinhPH.ContractAssetThinhPhRepository _repository;
        public ContractAssetThinhPhService() { }

        public async Task<int> CreateAsync(ContractAssetThinhPh asset)
        {
            throw new NotImplementedException();
        }

        public async Task<ContractAssetThinhPh> GetAllAssetsAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<List<ContractAssetThinhPh>> GetAssetsByContractIdAsync(int contractIdThinhPh)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> RemoveAsync(int? id)
        {
            throw new NotImplementedException();
        }

        public async Task<int> UpdateAsync(ContractAssetThinhPh asset)
        {
            throw new NotImplementedException();
        }
    }
}
