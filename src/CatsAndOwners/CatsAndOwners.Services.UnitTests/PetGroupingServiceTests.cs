using System.Collections;
using System.Collections.Generic;
using System.Linq;
using CatsAndOwners.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CatsAndOwners.Services.UnitTests
{
    [TestClass]
    public class PetGroupingServiceTests
    {
        private readonly PetGroupingService _petGroupingService = new PetGroupingService();

        [TestMethod]
        public void GetPetNamesByOwner_WithSingleOwnerAndPet_ReturnsGenderAndPetName()
        {
            // ARRANGE
            var catName = "Otis";
            var owners = new List<Owner>
            {
                new Owner {
                    Gender = Gender.Male,
                    Pets = new List<Pet>
                    {
                        new Pet { Name = catName, Type = PetType.Cat }   
                    }
                }
            };


            // ACT
            var result = _petGroupingService.GetPetNamesByOwner(owners);


            // ASSERT
            Assert.AreEqual(Gender.Male, result.Single().Key);
            Assert.AreEqual(catName, result.Single().Value.Single());
        }

        // TODO test cases for non-cats

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
