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

        public async Task<IList<Owner>> GetPetsOwnersAsync(string url)
        {
            // retrieve the list of owners; if an exception is thrown or 
            // an invalid response is received then we can't deal with 
            // it here, so it will be propagated to the caller
            var result = await _httpClient.GetAsync(url);
            result.EnsureSuccessStatusCode();

            // parse the response into the model types
            var json = await result.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<IList<Owner>>(json);
        }
    }
}
