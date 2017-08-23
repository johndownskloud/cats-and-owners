using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using CatsAndOwners.Interfaces;
using CatsAndOwners.Models;
using Newtonsoft.Json;

namespace CatsAndOwners.Services
{
    public class PetOwnerRetrievalService : IPetOwnerRetrievalService
    {
        private readonly HttpClient _httpClient;

        public PetOwnerRetrievalService()
        {
            _httpClient = new HttpClient();
        }

        public async Task<IList<Owner>> GetPetsOwnersAsync()
        {
            var result = await _httpClient.GetAsync("http://agl-developer-test.azurewebsites.net/people.json");
            var json = await result.Content.ReadAsStringAsync();

            var owners = JsonConvert.DeserializeObject<IList<Owner>>(json);
            return owners;
        }
    }
}
