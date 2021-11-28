using SentimentAnalysisTool.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SentimentAnalysisTool.Services.Interfaces
{
    public interface IRecordsService
    {
        Task<bool> AddRecordAsync(RecordModel record, string baseUrl, HttpClient httpClient);
        Task<bool> DeleteRecordAsync(int recordId, string baseUrl, HttpClient httpClient);
        Task<RecordModel> FetchRecordsAsync(int recordId, string baseUrl, HttpClient httpClient);
    }
}
