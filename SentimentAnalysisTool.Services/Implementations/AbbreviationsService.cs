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
    public class AbbreviationsService : IAbbreviationsService
    {
        private readonly HttpClient _httpClient;
        public AbbreviationsService(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.DefaultRequestHeaders.Add("Apikey", "MyUltimateSecretKeyNYAHAHAHAHAHAHAHA");
            _httpClient.Timeout = TimeSpan.FromMinutes(15);
        }

        public async Task<bool> AddAbbreviationsAsync(IFormFile file, int corpusTypeId, string baseUrl)
        {
            var form = new MultipartFormDataContent();
            var ms = new MemoryStream();
            file.CopyTo(ms);
            var fileBytes = ms.ToArray();
            form.Add(new ByteArrayContent(fileBytes, 0, fileBytes.Length), "file", file.FileName);

            var response = await _httpClient.PostAsync($"{baseUrl}/api/Abbreviations/{corpusTypeId}", form);
            var responseCode = response.IsSuccessStatusCode;

            if (responseCode)
                return true;

            return false;
        }

        public async Task<bool> DeleteAbbreviationAsync(int? abbreviationId, string baseUrl)
        {
            var response = await _httpClient.DeleteAsync($"{baseUrl}/api/Abbreviations/{abbreviationId}");
            var responseCode = response.IsSuccessStatusCode;

            if (responseCode)
                return true;

            return false;
        }

        public async Task<IEnumerable<AbbreviationModel>> FetchAbbreviationsAsync(int? corpusTypeId, string baseUrl)
        {
            var response = await _httpClient.GetAsync($"{baseUrl}/api/Abbreviations/{corpusTypeId}");
            var responseCode = response.IsSuccessStatusCode;

            if (responseCode)
                return await response.Content.ReadAsAsync<IEnumerable<AbbreviationModel>>();

            return new List<AbbreviationModel>();
        }
    }
}
