using System.Collections.Generic;
using System.Linq;
using CatsAndOwners.Interfaces;
using CatsAndOwners.Models;

namespace CatsAndOwners.Services
{
    public class PetGroupingService : IPetGroupingService
    {
        public IDictionary<Gender, IList<string>> GetPetNamesByOwner(IEnumerable<Owner> owners)
        {
            // if the owners list is not provided, we return an empty result
            if (owners == null || !owners.Any())
            {
                return new Dictionary<Gender, IList<string>>();
            }
            
            // TODO
            throw new System.NotImplementedException();
        }
    }
}
