using System.Collections;
using System.Collections.Generic;
using CatsAndOwners.Models;

namespace CatsAndOwners.Interfaces
{
    public interface IPetGroupingService
    {
        IDictionary<Gender, IList<string>> GetPetNamesByOwner(IEnumerable<Owner> owners);
    }
}
