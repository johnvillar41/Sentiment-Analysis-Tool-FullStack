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
    public class CorpusWordsService : ICorpusWordsService
    {
        public async Task<bool> AddCorpusWordAsync(CorpusWordModel corpusWord, string baseUrl, HttpClient httpClient)
        {
            var response = await httpClient.PostAsJsonAsync<CorpusWordModel>($"{baseUrl}/api/CorpusWords", corpusWord);
            var responseCode = response.IsSuccessStatusCode;

            if (responseCode)
                return true;

            return false;
        }

        public async Task<bool> AddCorpusWordsAsync(IEnumerable<CorpusWordModel> corpusWords, string baseUrl, HttpClient httpClient)
        {
            var response = await httpClient.PostAsJsonAsync<IEnumerable<CorpusWordModel>>($"{baseUrl}/api/CorpusWords", corpusWords);
            var responseCode = response.IsSuccessStatusCode;

            if (responseCode)
                return true;

            return false;
        }

        public async Task<bool> DeleteCorpusWordAsync(int corpusWordId, string baseUrl, HttpClient httpClient)
        {
            var response = await httpClient.DeleteAsync($"{baseUrl}/api/CorpusWords/{corpusWordId}");
            var responseCode = response.IsSuccessStatusCode;

            if (responseCode)
                return true;

            return false;
        }

        public async Task<CorpusWordModel> FetchCorpusWordAsync(int corpusId, string baseUrl, HttpClient httpClient)
        {
            var response = await httpClient.GetAsync($"{baseUrl}/api/CorpusWords/{corpusId}");
            var responseCode = response.IsSuccessStatusCode;

            if (responseCode)
                return await response.Content.ReadAsAsync<CorpusWordModel>();

            return new CorpusWordModel();
        }
    }
}
