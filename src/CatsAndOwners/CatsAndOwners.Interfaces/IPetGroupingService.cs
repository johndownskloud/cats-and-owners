﻿using System.Collections.Generic;
using CatsAndOwners.Models;

namespace CatsAndOwners.Interfaces
{
    public interface IPetGroupingService
    {
        IDictionary<Gender, List<string>> GetPetNamesByOwnerGender(IList<Owner> owners, PetType typeFilter = PetType.Cat);
    }
}
