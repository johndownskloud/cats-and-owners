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
        public void GetPetNamesByOwner_WithSingleOwnerAndSingleCat_ReturnsGenderAndCatName()
        {
            // ARRANGE
            const string catName = "Otis";
            var owners = new List<Owner>
            {
                new Owner
                {
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

        [TestMethod]
        public void GetPetNamesByOwner_WithSingleOwnerAndDog_ReturnsEmptyDictionary()
        {
            // ARRANGE
            var owners = new List<Owner>
            {
                new Owner
                {
                    Gender = Gender.Male,
                    Pets = new List<Pet>
                    {
                        new Pet { Name = "Fido", Type = PetType.Dog }
                    }
                }
            };


            // ACT
            var result = _petGroupingService.GetPetNamesByOwner(owners);


            // ASSERT
            Assert.AreEqual(0, result.Count);
        }
        

        [TestMethod]
        public void GetPetNamesByOwner_WithMultipleMaleOwnersAndSingleCatEach_ReturnsGendersAndCatName()
        {
            // ARRANGE
            const string catName1 = "Otis";
            const string catName2 = "Basil";
            var owners = new List<Owner>
            {
                new Owner
                {
                    Gender = Gender.Male,
                    Pets = new List<Pet>
                    {
                        new Pet { Name = catName1, Type = PetType.Cat }
                    }
                },
                new Owner
                {
                    Gender = Gender.Male,
                    Pets = new List<Pet>
                    {
                        new Pet { Name = catName2, Type = PetType.Cat }
                    }
                }
            };


            // ACT
            var result = _petGroupingService.GetPetNamesByOwner(owners);


            // ASSERT
            Assert.AreEqual(Gender.Male, result.Single().Key);
            Assert.AreEqual(catName1, result.Single().Value.First());
            Assert.AreEqual(catName2, result.Single().Value.Skip(1).First());
        }

        [TestMethod]
        public void GetPetNamesByOwner_WithMultipleOwnersAndMultiplePets_ReturnsGendersAndCatsNames()
        {
            // ARRANGE
            const string catName1 = "Otis";
            const string catName2 = "Basil";
            var owners = new List<Owner>
            {
                new Owner
                {
                    Gender = Gender.Male,
                    Pets = new List<Pet>
                    {
                        new Pet { Name = catName1, Type = PetType.Cat },
                        new Pet { Name = "Fido", Type = PetType.Dog }
                    }
                },
                new Owner
                {
                    Gender = Gender.Male,
                    Pets = new List<Pet>
                    {
                        new Pet { Name = catName2, Type = PetType.Cat },
                        new Pet { Name = "Nemo", Type = PetType.Fish }
                    }
                }
            };


            // ACT
            var result = _petGroupingService.GetPetNamesByOwner(owners);


            // ASSERT
            Assert.AreEqual(Gender.Male, result.Single().Key);
            Assert.AreEqual(catName1, result.Single().Value.First());
            Assert.AreEqual(catName2, result.Single().Value.Skip(1).First());
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
