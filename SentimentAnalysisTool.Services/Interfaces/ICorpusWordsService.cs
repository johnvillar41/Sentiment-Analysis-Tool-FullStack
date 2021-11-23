using SentimentAnalysisTool.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SentimentAnalysisTool.Services.Interfaces
{
    public interface ICorpusWordsService
    {
        Task<CorpusWordModel> FetchCorpusWordAsync(int corpusId, string baseUrl, HttpClient httpClient);
        Task<bool> AddCorpusWordsAsync(IEnumerable<CorpusWordModel> corpusWords, string baseUrl, HttpClient httpClient);
        Task<bool> AddCorpusWordAsync(CorpusWordModel corpusWord, string baseUrl, HttpClient httpClient);
        Task<bool> DeleteCorpusWordAsync(int corpusWordId, string baseUrl, HttpClient httpClient);
    }
}
