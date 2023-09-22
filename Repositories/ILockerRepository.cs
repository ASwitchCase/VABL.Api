using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VABL.Api.Models;

namespace VABL.Api.Repositories
{
    public interface ILockerRepository
    {
        Task<LockerList> UpdateAsync(string id, LockerList newList);
        Task<LockerList> AddAsync(LockerList newList);
        Task<IEnumerable<LockerList>> GetAllAsync();
        Task<LockerList> GetAsync(string id);
        Task DeleteAsync(string id);
    }
}