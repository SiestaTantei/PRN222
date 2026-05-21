using Manga.Entites.ThinhPH.Models;
using Manga.Repositories.ThinhPH;
using Manga.Services.ThinhPH.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manga.Services.ThinhPH
{
    public class ContractMasterThinhPhService : Interface.IContractMasterThinhPhService
    {
        private readonly ContractMasterThinhPhRepository _repository;
        public ContractMasterThinhPhService() { }
        public ContractMasterThinhPhService(ContractMasterThinhPhRepository repository) => _repository = repository;

        public async Task<int> CreateAsync(ContractMasterThinhPh orders)
        {
            try
            {
                return await _repository.CreateAsync(orders);

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
                var item = await _repository.GetByIdAsync(id);
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

        public async Task<List<ContractMasterThinhPh>> GetAllsAsync()
        {
            try
            {
                return await _repository.GetAllsAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<ContractMasterThinhPh?> GetByIdAsync(int? id)
        {
            try
            {
                return await _repository.GetByIdAsync(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<ContractMasterThinhPh>> SearchAsync(int? seriesId, DateTime? fromDate, DateTime? toDate, bool? isExclusive)
        {
            try
            {
                return await _repository.SearchAsync(seriesId, fromDate, toDate, isExclusive);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[Service Error] SearchAsync failed: {ex.Message}");
                return new List<ContractMasterThinhPh>();
            }
        }

        public async Task<int> UpdateAsync(ContractMasterThinhPh orders)
        {
            try
            {
                return await _repository.UpdateAsync(orders);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
