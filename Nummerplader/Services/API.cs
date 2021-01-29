using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Nummerplader.Models;
using Newtonsoft.Json;
namespace Nummerplader.Services
{
    public class API
    {
        private HttpClient client;
        protected readonly string Token = "ojd5b6np5d66o61xaskcmpypxterovsk";
        public API()
        {
            client = new HttpClient();
            client.DefaultRequestHeaders.Add("X-AUTH-TOKEN", Token);
        }

        public async Task<NummerPladerModel> GetNummerPladerByRegistreingsNummer(string regNr)
        {

            NummerPladerModel bil = null;
            var response = await client.GetAsync($"https://v1.motorapi.dk/vehicles/{regNr}").ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                var responseBody = await response.Content.ReadAsStringAsync();
                bil = JsonConvert.DeserializeObject<NummerPladerModel>(responseBody);
            }

            return bil;
        }
    }
}
