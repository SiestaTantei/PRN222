using Manga.Entites.ThinhPH.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manga.Services.ThinhPH.Interface
{
    public interface IRoyaltyPaymentThinhPhService
    {
        Task<List<RoyaltyPaymentThinhPh> > GetAllPaymentAsync();
        Task<RoyaltyPaymentThinhPh?> GetPaymentsByContractIdAsync(int? id);
        Task<List<RoyaltyPaymentThinhPh> > GetPaymentsByDateRangeAsync(DateTime fromDate, DateTime toDate);
        Task<int> CreateAsync(RoyaltyPaymentThinhPh orders);

        Task<int> UpdateAsync(RoyaltyPaymentThinhPh orders);

        Task<bool> RemoveAsync(int? id);
    }
}
