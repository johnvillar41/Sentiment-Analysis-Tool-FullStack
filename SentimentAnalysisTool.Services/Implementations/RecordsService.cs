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
    public class RecordsService : IRecordsService
    {
        public async Task<bool> AddRecordAsync(RecordModel record, string baseUrl, HttpClient httpClient)
        {
            var response = await httpClient.PostAsJsonAsync<RecordModel>($"{baseUrl}/api/Records", record);
            var responseCode = response.IsSuccessStatusCode;

            if (responseCode)
                return true;

            return false;
        }

        public async Task<bool> DeleteRecordAsync(int recordId, string baseUrl, HttpClient httpClient)
        {
            var response = await httpClient.DeleteAsync($"{baseUrl}/api/Records/{recordId}");
            var responseCode = response.IsSuccessStatusCode;

            if (responseCode)
                return true;

            return false;
        }
    }
}
