using SentimentAnalysisTool.Data.Models;
using SentimentAnalysisTool.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SentimentAnalysisTool.Services.Implementations
{
    public class AbbreviationsService : IAbbreviationsService
    {
        private readonly HttpClient _httpClient;
        public AbbreviationsService(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.DefaultRequestHeaders.Add("Apikey", "MyUltimateSecretKeyNYAHAHAHAHAHAHAHA");
        }

        public Task<bool> DeleteAbbreviationAsync(int? corpusTypeId, string baseUrl)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<AbbreviationModel>> FetchAbbreviationsAsync(int? corpusTypeId, string baseUrl)
        {
            var response = await _httpClient.GetAsync($"{baseUrl}/api/Abbreviations/{corpusTypeId}");
            var responseCode = response.IsSuccessStatusCode;

            if (responseCode)
                return await response.Content.ReadAsAsync<IEnumerable<AbbreviationModel>>();

            return new List<AbbreviationModel>();
        }
    }
}
