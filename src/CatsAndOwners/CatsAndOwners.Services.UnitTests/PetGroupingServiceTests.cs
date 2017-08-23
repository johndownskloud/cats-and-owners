using System.Collections;
using System.Collections.Generic;
using CatsAndOwners.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CatsAndOwners.Services.UnitTests
{
    [TestClass]
    public class PetGroupingServiceTests
    {
        private PetGroupingService _petGroupingService;

        [TestMethod]
        public void GetPetNamesByOwner_WithSingleOwnerAndPet_ReturnsGenderAndPetName()
        {
        }

        [TestMethod]
        public void GetPetNamesByOwner_WithMultipleOwnersAndSinglePet_ReturnsGendersAndPetName()
        {

        }

        [TestMethod]
        public void GetPetNamesByOwner_WithMultipleOwnersAndMultiplePets_ReturnsGendersAndPetName()
        {

        }

        [TestMethod]
        public void GetPetNamesByOwner_WithSingleOwnerWithNullPetName_ReturnsEmptyDictionary()
        {

        }

        [TestMethod]
        public void GetPetNamesByOwner_WithNullOwnersList_ReturnsEmptyDictionary()
        {
            // ACT
            var result = _petGroupingService.GetPetNamesByOwner(null);


            // ASSERT
            Assert.AreEqual(0, result.Count);
        }

        [TestMethod]
        public void GetPetNamesByOwner_WithEmptyOwnersList_ReturnsEmptyDictionary()
        {
            // ARRANGE
            var owners = new List<Owner>();


            // ACT
            var result = _petGroupingService.GetPetNamesByOwner(owners);


            // ASSERT
            Assert.AreEqual(0, result.Count);
        }
    }
}
