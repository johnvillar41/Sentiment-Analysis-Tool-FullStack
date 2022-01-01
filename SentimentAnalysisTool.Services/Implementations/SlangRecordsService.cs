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
    public class SlangRecordsService : ISlangRecordsService
    {
        private readonly HttpClient _httpClient;
        public SlangRecordsService()
        {
            _httpClient = new HttpClient();
        }
        public async Task<bool> AddSlangRecordAsync(SlangRecordModel slangRecord, string baseUrl)
        {
            var response = await _httpClient.PostAsJsonAsync<SlangRecordModel>($"{baseUrl}/api/SlangRecords", slangRecord);
            var responseCode = response.IsSuccessStatusCode;

            if (responseCode)
                return true;

            return false;
        }

        public async Task<bool> AddSlangRecordsAsync(IEnumerable<SlangRecordModel> slangRecords, string baseUrl)
        {
            var response = await _httpClient.PostAsJsonAsync<IEnumerable<SlangRecordModel>>($"{baseUrl}/api/SlangRecords", slangRecords);
            var responseCode = response.IsSuccessStatusCode;

            if (responseCode)
                return true;

            return false;
        }

        public async Task<bool> DeleteSlangRecordAsync(int slangRecordId, string baseUrl)
        {
            var response = await _httpClient.DeleteAsync($"{baseUrl}/api/SlangRecords/{slangRecordId}");
            var responseCode = response.IsSuccessStatusCode;

            if (responseCode)
                return true;

            return false;
        }

        public async Task<IEnumerable<SlangRecordModel>> FetchAllSlangRecordAsync(int? corpusTypeId, string baseUrl)
        {
            var response = await _httpClient.GetAsync($"{baseUrl}/api/SlangRecords/{corpusTypeId}");
            var responseCode = response.IsSuccessStatusCode;
            if (responseCode)
                return await response.Content.ReadAsAsync<IEnumerable<SlangRecordModel>>();

            return new List<SlangRecordModel>();
        }
    }
}
