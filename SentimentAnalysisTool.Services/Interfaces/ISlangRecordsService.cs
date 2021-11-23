using SentimentAnalysisTool.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SentimentAnalysisTool.Services.Interfaces
{
    public interface ISlangRecordsService
    {
        Task<bool> AddSlangRecordAsync(SlangRecordModel slangRecord, string baseUrl, HttpClient httpClient);
        Task<bool> AddSlangRecordsAsync(IEnumerable<SlangRecordModel> slangRecords, string baseUrl, HttpClient httpClient);
        Task<bool> DeleteSlangRecordAsync(int slangRecordId, string baseUrl, HttpClient httpClient);
    }
}
