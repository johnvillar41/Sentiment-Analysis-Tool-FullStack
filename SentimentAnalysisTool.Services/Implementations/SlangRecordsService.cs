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
        public async Task<bool> AddSlangRecordAsync(SlangRecordModel slangRecord, string baseUrl, HttpClient httpClient)
        {
            var response = await httpClient.PostAsJsonAsync<SlangRecordModel>($"{baseUrl}/api/SlangRecords", slangRecord);
            var responseCode = response.IsSuccessStatusCode;

            if (responseCode)
                return true;

            return false;
        }

        public async Task<bool> AddSlangRecordsAsync(IEnumerable<SlangRecordModel> slangRecords, string baseUrl, HttpClient httpClient)
        {
            var response = await httpClient.PostAsJsonAsync<IEnumerable<SlangRecordModel>>($"{baseUrl}/api/SlangRecords", slangRecords);
            var responseCode = response.IsSuccessStatusCode;

            if (responseCode)
                return true;

            return false;
        }

        public async Task<bool> DeleteSlangRecordAsync(int slangRecordId, string baseUrl, HttpClient httpClient)
        {
            var response = await httpClient.DeleteAsync($"{baseUrl}/api/SlangRecords/{slangRecordId}");
            var responseCode = response.IsSuccessStatusCode;

            if (responseCode)
                return true;

            return false;
        }
    }
}
