using System.Collections.Generic;
using CatsAndOwners.Models;

namespace CatsAndOwners.Interfaces
{
    public interface IPetOwnerRetrievalService
    {
        IList<Owner> GetPetsOwners();
    }
}
