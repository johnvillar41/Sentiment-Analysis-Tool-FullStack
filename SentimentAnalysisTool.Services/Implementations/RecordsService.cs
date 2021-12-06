using Microsoft.AspNetCore.Http;
using SentimentAnalysisTool.Data.Models;
using SentimentAnalysisTool.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace SentimentAnalysisTool.Services.Implementations
{
    public class RecordsService : IRecordsService
    {
        private readonly HttpClient _httpClient;
        public RecordsService()
        {
            _httpClient = new HttpClient();
        }
        public async Task<bool> AddRecordAsync(IFormFile file, string baseUrl)
        {
            _httpClient.DefaultRequestHeaders.Add("Apikey", "MyUltimateSecretKeyNYAHAHAHAHAHAHAHA");
            var form = new MultipartFormDataContent();
            using var ms = new MemoryStream();
            file.CopyTo(ms);
            var fileBytes = ms.ToArray();
            string s = Convert.ToBase64String(fileBytes);
            form.Add(new ByteArrayContent(fileBytes, 0, fileBytes.Length), "file", file.FileName);
            var response = await _httpClient.PostAsync($"{baseUrl}/api/Records/Upload?algorithmnType=Vader", form);
            if (response.IsSuccessStatusCode)
                return true;

            return false;
        }

        public async Task<bool> DeleteRecordAsync(int recordId, string baseUrl)
        {
            var response = await _httpClient.DeleteAsync($"{baseUrl}/api/Records/{recordId}");
            var responseCode = response.IsSuccessStatusCode;

            if (responseCode)
                return true;

            return false;
        }

        public async Task<RecordModel> FetchRecordsAsync(int recordId, string baseUrl)
        {
            var response = await _httpClient.GetAsync($"{baseUrl}/api/Records/{recordId}");
            var responseCode = response.IsSuccessStatusCode;

            if (responseCode)
                return await response.Content.ReadAsAsync<RecordModel>();

            return null;
        }
    }
}
