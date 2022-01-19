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
    public class WordFrequencyService : IWordFrequencyService
    {
        private readonly HttpClient _httpClient;
        public WordFrequencyService(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.DefaultRequestHeaders.Add("Apikey", "MyUltimateSecretKeyNYAHAHAHAHAHAHAHA");
        }
        public async Task<bool> AddWordFrequencyAsync(IEnumerable<WordFrequencyModel> wordFrequencies, string baseUrl)
        {
            var response = await _httpClient.PostAsJsonAsync<IEnumerable<WordFrequencyModel>>($"{baseUrl}/api/WordFrequency", wordFrequencies);
            var responseCode = response.IsSuccessStatusCode;

            if (responseCode)
                return true;

            return false;
        }

        public async Task<bool> AddWordFrequencyAsync(WordFrequencyModel wordFrequency, string baseUrl)
        {
            var response = await _httpClient.PostAsJsonAsync<WordFrequencyModel>($"{baseUrl}/api/WordFrequency", wordFrequency);
            var responseCode = response.IsSuccessStatusCode;

            if (responseCode)
                return true;

            return false;
        }
    }
}
