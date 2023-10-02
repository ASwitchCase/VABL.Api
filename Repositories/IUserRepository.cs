using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VABL.Api.Models;

namespace VABL.Api.Repositories
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetAllAsync();
    }
}