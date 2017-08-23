using System.Collections;
using System.Collections.Generic;
using System.Linq;
using CatsAndOwners.Interfaces;
using CatsAndOwners.Models;

namespace CatsAndOwners.Services
{
    public class PetGroupingService : IPetGroupingService
    {
        public IDictionary<Gender, List<string>> GetPetNamesByOwner(IList<Owner> owners)
        {
            // if the owners list is not provided, we return an empty result
            if (owners == null || !owners.Any())
            {
                return new Dictionary<Gender, List<string>>();
            }

            // TODO
            throw new System.NotImplementedException();
        }
    }
}
