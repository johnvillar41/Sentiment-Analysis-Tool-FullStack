using SentimentAnalysisTool.Data.Models;
using System.Threading.Tasks;

namespace SentimentAnalysisTool.Services.Interfaces
{
    public interface IRecordsService
    {
        Task<RecordModel<T>> AddRecordAsync<T>(UploadCsvFileModel file, string baseUrl);
        Task<bool> DeleteRecordAsync(int recordId, string baseUrl);
        Task<RecordModel<T>> FetchRecordsAsync<T>(int recordId, string baseUrl);
    }
}
