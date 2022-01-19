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
    public class CorpusRecordService : ICorpusRecordService
    {
        private readonly HttpClient _httpClient;
        public CorpusRecordService(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.DefaultRequestHeaders.Add("Apikey", "MyUltimateSecretKeyNYAHAHAHAHAHAHAHA");
        }
        public async Task<bool> AddCorpusRecordAsync(CorpusRecordModel corpus, string baseUrl)
        {
            var response = await _httpClient.PostAsJsonAsync<CorpusRecordModel>($"{baseUrl}/api/CorpusRecords", corpus);
            var responseCode = response.IsSuccessStatusCode;

            if (responseCode)
                return true;

            return false;
        }
    }
}
