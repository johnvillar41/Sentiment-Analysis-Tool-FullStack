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
        public async Task<RecordModel<T>> AddRecordAsync<T>(IFormFile file, string baseUrl)
        {
            try
            {
                var form = await ParseFile(file);
                var genericType = typeof(T);
                HttpResponseMessage response = null;
                RecordModel<T> jsonModel = null;
                if (genericType.Name.Equals("SentiWordNetModel"))
                {
                    response = await _httpClient.PostAsync($"{baseUrl}/api/Records/Upload?algorithmnType=SentiWordNet", form);
                }
                if (genericType.Name.Equals("VaderModel"))
                {
                    response = await _httpClient.PostAsync($"{baseUrl}/api/Records/Upload?algorithmnType=Vader", form);
                }
                if (genericType.Name.Equals("HybridModel"))
                {
                    response = await _httpClient.PostAsync($"{baseUrl}/api/Records/Upload?algorithmnType=Hybrid", form);
                }
                jsonModel = await response.Content.ReadAsAsync<RecordModel<T>>();
                return jsonModel;
            }
            catch (HttpRequestException)
            {
                throw new HttpRequestException("Not connected from server!");
            }            
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
        private async Task<MultipartFormDataContent> ParseFile(IFormFile file)
        {
            var task = await Task.Run(() =>
            {
                _httpClient.DefaultRequestHeaders.Add("Apikey", "MyUltimateSecretKeyNYAHAHAHAHAHAHAHA");
                var form = new MultipartFormDataContent();
                var ms = new MemoryStream();
                file.CopyTo(ms);
                var fileBytes = ms.ToArray();
                //var s = Convert.ToBase64String(fileBytes);
                form.Add(new ByteArrayContent(fileBytes, 0, fileBytes.Length), "file", file.FileName);
                return form;
            });

            return task;
        }
    }
}
