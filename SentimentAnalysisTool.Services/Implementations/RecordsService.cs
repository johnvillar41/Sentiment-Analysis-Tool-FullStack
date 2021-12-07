using Microsoft.AspNetCore.Http;
using SentimentAnalysisTool.Data.Models;
using SentimentAnalysisTool.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text.Json;
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
        public async Task<List<CommentModel<T>>> AddRecordAsync<T>(IFormFile file, string baseUrl)
        {
            _httpClient.DefaultRequestHeaders.Add("Apikey", "MyUltimateSecretKeyNYAHAHAHAHAHAHAHA");
            var form = new MultipartFormDataContent();
            using var ms = new MemoryStream();
            file.CopyTo(ms);
            var fileBytes = ms.ToArray();            
            var s = Convert.ToBase64String(fileBytes);
            form.Add(new ByteArrayContent(fileBytes, 0, fileBytes.Length), "file", file.FileName);
            var response = await _httpClient.PostAsync($"{baseUrl}/api/Records/Upload?algorithmnType=Vader", form);
            var jsonModel = await response.Content.ReadAsAsync<List<CommentModel<T>>>();            
            return jsonModel;           
        }

        public async Task<bool> DeleteRecordAsync(int recordId, string baseUrl)
        {
            var response = await _httpClient.DeleteAsync($"{baseUrl}/api/Records/{recordId}");
            var responseCode = response.IsSuccessStatusCode;

            if (responseCode)
                return true;

            return false;
        }

        public async Task<RecordModel<T>> FetchRecordsAsync<T>(int recordId, string baseUrl)
        {
            var response = await _httpClient.GetAsync($"{baseUrl}/api/Records/{recordId}");
            var responseCode = response.IsSuccessStatusCode;

            if (responseCode)
                return await response.Content.ReadAsAsync<RecordModel<T>>();

            return null;
        }
    }
}
