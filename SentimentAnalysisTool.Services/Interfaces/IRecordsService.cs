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
    public interface IRecordsService
    {
        Task<CommentModel<T>> AddRecordAsync<T>(IFormFile file, string baseUrl);
        Task<bool> DeleteRecordAsync(int recordId, string baseUrl);
        Task<RecordModel> FetchRecordsAsync(int recordId, string baseUrl);
    }
}
