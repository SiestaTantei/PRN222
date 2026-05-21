using Manga.Entites.ThinhPH.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manga.Services.ThinhPH.Interface
{
    public interface IContractMasterThinhPhService
    {
        Task<List<ContractMasterThinhPh>> GetAllsAsync();
        Task<ContractMasterThinhPh?> GetByIdAsync(int? id);
        Task<List<ContractMasterThinhPh>> SearchAsync(int? seriesId, DateTime? fromDate, DateTime? toDate, bool? isExclusive);
        Task<int> CreateAsync(ContractMasterThinhPh orders);

        Task<int> UpdateAsync(ContractMasterThinhPh orders);

        Task<bool> RemoveAsync(int? id);
    }
}
