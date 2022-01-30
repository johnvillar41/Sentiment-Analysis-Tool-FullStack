using Microsoft.AspNetCore.Http;
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
        Task<bool> AddSlangRecordAsync(SlangRecordModel slangRecord, string baseUrl);
        Task<bool> AddSlangRecordsAsync(IEnumerable<SlangRecordModel> slangRecords, string baseUrl);
        Task<bool> AddSlangRecordsAsync(IFormFile file, int corpusTypeId, string baseUrl);
        Task<bool> DeleteSlangRecordAsync(int slangRecordId, string baseUrl);
        Task<IEnumerable<SlangRecordModel>> FetchAllSlangRecordAsync(int? corpusTypeId, string baseUrl);
    }
}
