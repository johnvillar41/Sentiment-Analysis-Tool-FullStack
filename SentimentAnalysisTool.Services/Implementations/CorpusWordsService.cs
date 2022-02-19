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
    public class CorpusWordsService : ICorpusWordsService
    {
        private readonly HttpClient _httpClient;
        public CorpusWordsService(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.DefaultRequestHeaders.Add("Apikey", "MyUltimateSecretKeyNYAHAHAHAHAHAHAHA");
            _httpClient.Timeout = TimeSpan.FromMinutes(15);
        }
        public async Task<bool> AddCorpusWordAsync(CorpusWordModel corpusWord, string baseUrl)
        {
            var response = await _httpClient.PostAsJsonAsync<CorpusWordModel>($"{baseUrl}/api/CorpusWords", corpusWord);
            var responseCode = response.IsSuccessStatusCode;

            if (responseCode)
                return true;

            return false;
        }

        public async Task<bool> AddCorpusWordsAsync(IEnumerable<CorpusWordModel> corpusWords, string baseUrl)
        {
            var response = await _httpClient.PostAsJsonAsync<IEnumerable<CorpusWordModel>>($"{baseUrl}/api/CorpusWords", corpusWords);
            var responseCode = response.IsSuccessStatusCode;

            if (responseCode)
                return true;

            return false;
        }

        public async Task<bool> AddCorpusWordsAsync(IFormFile file, int corpusTypeId, string baseUrl)
        {
            var form = new MultipartFormDataContent();
            var ms = new MemoryStream();
            file.CopyTo(ms);
            var fileBytes = ms.ToArray();
            form.Add(new ByteArrayContent(fileBytes, 0, fileBytes.Length), "file", file.FileName);

            var response = await _httpClient.PostAsync($"{baseUrl}/api/CorpusWords/{corpusTypeId}", form);
            var responseCode = response.IsSuccessStatusCode;
            if (responseCode)
                return true;

            return false;
        }

        public async Task<bool> DeleteCorpusWordAsync(int corpusWordId, string baseUrl)
        {
            var response = await _httpClient.DeleteAsync($"{baseUrl}/api/CorpusWords/{corpusWordId}");
            var responseCode = response.IsSuccessStatusCode;

            if (responseCode)
                return true;

            return false;
        }

        public async Task<CorpusWordModel> FetchCorpusWordAsync(int corpusId, string baseUrl)
        {
            var response = await _httpClient.GetAsync($"{baseUrl}/api/CorpusWords/{corpusId}");
            var responseCode = response.IsSuccessStatusCode;

            if (responseCode)
                return await response.Content.ReadAsAsync<CorpusWordModel>();

            return new CorpusWordModel();
        }

        public async Task<IEnumerable<CorpusWordModel>> FetchCorpusWordsAsync(int? corpusTypeId, string baseUrl)
        {
            var response = await _httpClient.GetAsync($"{baseUrl}/api/CorpusWords/{corpusTypeId}");
            var responseCode = response.IsSuccessStatusCode;

            if (responseCode)
                return await response.Content.ReadAsAsync<IEnumerable<CorpusWordModel>>();

            return new List<CorpusWordModel>();
        }
    }
}
