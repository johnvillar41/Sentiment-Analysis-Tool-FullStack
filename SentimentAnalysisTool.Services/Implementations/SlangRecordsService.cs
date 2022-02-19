using Microsoft.AspNetCore.Http;
using SentimentAnalysisTool.Data.Models;
using SentimentAnalysisTool.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SentimentAnalysisTool.Services.Implementations
{
    public class SlangRecordsService : ISlangRecordsService
    {
        private readonly HttpClient _httpClient;
        public SlangRecordsService(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.DefaultRequestHeaders.Add("Apikey", "MyUltimateSecretKeyNYAHAHAHAHAHAHAHA");
            _httpClient.Timeout = TimeSpan.FromMinutes(15);
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

        public async Task<bool> AddSlangRecordsAsync(IFormFile file, int corpusTypeId, string baseUrl)
        {
            var form = new MultipartFormDataContent();
            var ms = new MemoryStream();
            file.CopyTo(ms);
            var fileBytes = ms.ToArray();
            form.Add(new ByteArrayContent(fileBytes, 0, fileBytes.Length), "file", file.FileName);

            var response = await _httpClient.PostAsync($"{baseUrl}/api/SlangRecords/AddSlangRecords/{corpusTypeId}", form);
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
