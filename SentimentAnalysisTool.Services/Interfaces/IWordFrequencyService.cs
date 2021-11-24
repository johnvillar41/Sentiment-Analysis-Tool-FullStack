using SentimentAnalysisTool.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SentimentAnalysisTool.Services.Interfaces
{
    public interface IWordFrequencyService
    {
        Task<bool> AddWordFrequencyAsync(IEnumerable<WordFrequencyModel> wordFrequencies, string baseUrl, HttpClient httpClient);
        Task<bool> AddWordFrequencyAsync(WordFrequencyModel wordFrequency, string baseUrl, HttpClient httpClient);
    }
}
