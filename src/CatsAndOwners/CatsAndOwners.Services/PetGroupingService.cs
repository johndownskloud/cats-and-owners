using System.Collections;
using System.Collections.Generic;
using System.Linq;
using CatsAndOwners.Interfaces;
using CatsAndOwners.Models;

namespace CatsAndOwners.Services
{
    public class PetGroupingService : IPetGroupingService
    {
        public IDictionary<Gender, List<string>> GetPetNamesByOwner(IList<Owner> owners, PetType typeFilter = PetType.Cat)
        {
            // if the owners list is not provided, we return an empty result
            if (owners == null || !owners.Any())
            {
                return new Dictionary<Gender, List<string>>();
            }

            // perform a grouping by gender, and return back just the pet names
            return owners
                .GroupBy(o => o.Gender)
                .Select(s => new
                {
                    OwnerGender = s.Key,
                    PetNames = s
                        .SelectMany(p => p.Pets)
                        .Select(p => p.Name)
                        .ToList()
                })
                .ToDictionary(keySelector: g => g.OwnerGender, elementSelector: g => g.PetNames);
        }
    }
}
