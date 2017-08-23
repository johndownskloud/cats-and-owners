using System;
using System.Collections.Generic;
using System.Net.Http;
using CatsAndOwners.Interfaces;
using CatsAndOwners.Models;

namespace CatsAndOwners.Services
{
    public class PetOwnerRetrievalService : IPetOwnerRetrievalService
    {
        private readonly HttpClient _httpClient;

        public PetOwnerRetrievalService()
        {
            _httpClient = new HttpClient();
        }

        public IList<Owner> GetPetsOwners()
        {
            throw new NotImplementedException();
        }
    }
}
