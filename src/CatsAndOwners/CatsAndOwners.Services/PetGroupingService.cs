using System.Collections.Generic;
using CatsAndOwners.Interfaces;
using CatsAndOwners.Models;

namespace CatsAndOwners.Services
{
    public class PetGroupingService : IPetGroupingService
    {
        public IDictionary<Gender, IList<string>> GetPetNamesByOwner(IEnumerable<Owner> owners)
        {
            throw new System.NotImplementedException();
        }
    }
}
