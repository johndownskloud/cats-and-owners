using System.Collections.Generic;
using System.Threading.Tasks;
using CatsAndOwners.Models;

namespace CatsAndOwners.Interfaces
{
    public interface IPetOwnerRetrievalService
    {
        Task<IList<Owner>> GetPetsOwnersAsync();
    }
}
