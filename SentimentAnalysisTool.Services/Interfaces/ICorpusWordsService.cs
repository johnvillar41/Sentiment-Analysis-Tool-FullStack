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
        Task<CorpusWordModel> FetchCorpusWordAsync(int corpusId, string baseUrl);
        Task<IEnumerable<CorpusWordModel>> FetchCorpusWordsAsync(int? corpusTypeId, string baseUrl);
        Task<bool> AddCorpusWordsAsync(IEnumerable<CorpusWordModel> corpusWords, string baseUrl);
        Task<bool> AddCorpusWordAsync(CorpusWordModel corpusWord, string baseUrl);
        Task<bool> DeleteCorpusWordAsync(int corpusWordId, string baseUrl);
    }
}
