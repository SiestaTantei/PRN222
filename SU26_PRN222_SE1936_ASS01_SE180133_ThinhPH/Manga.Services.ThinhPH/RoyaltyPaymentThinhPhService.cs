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
    public class RoyaltyPaymentThinhPhService : Interface.IRoyaltyPaymentThinhPhService
    {
        private readonly Repositories.ThinhPH.RoyaltyPaymentThinhPhRepository _repository;
        public RoyaltyPaymentThinhPhService(Repositories.ThinhPH.RoyaltyPaymentThinhPhRepository repository) => _repository = repository;

        public async Task<int> CreateAsync(RoyaltyPaymentThinhPh orders)
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
                var item = await _repository.GetPaymentsByContractIdAsync(id);
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
        public async Task<List<RoyaltyPaymentThinhPh>> GetAllPaymentAsync()
        {
            try
            {
                return await _repository.GetAllPaymentAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<RoyaltyPaymentThinhPh?> GetPaymentsByContractIdAsync(int? id)
        {

            try
            {
                return await _repository.GetPaymentsByContractIdAsync(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<RoyaltyPaymentThinhPh>> GetPaymentsByDateRangeAsync(DateTime fromDate, DateTime toDate)
        {
            try
            {
                if (fromDate > toDate)
                {
                    throw new ArgumentException("From date must be less than or equal to to date.");
                }
                return await _repository.GetPaymentsByDateRangeAsync(fromDate, toDate);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public async Task<int> UpdateAsync(RoyaltyPaymentThinhPh orders)
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
