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
        public ContractAssetThinhPhService(ContractAssetThinhPhRepository repository) => _repository = repository;

        public async Task<int> CreateAsync(ContractAssetThinhPh asset)
        {
            try
            {
                return await _repository.CreateAsync(asset);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<ContractAssetThinhPh> GetAllAssetsAsync()
        {
            try
            {
                return await _repository.GetAllAssetsAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<ContractAssetThinhPh> GetAssetsByContractIdAsync(int contractIdThinhPh)
        {
            try
            {
                return await _repository.GetAssetsByContractIdAsync(contractIdThinhPh);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public async Task<bool> RemoveAsync(int? id)
        {
            try
            {
                var item = await _repository.GetAssetsByContractIdAsync(id);
                if (item != null)
                {
                    return await _repository.RemoveAsync(item);
                }
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public Task<int> UpdateAsync(ContractAssetThinhPh asset)
        {
            try
            {
                return _repository.UpdateAsync(asset);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }
    }
}
