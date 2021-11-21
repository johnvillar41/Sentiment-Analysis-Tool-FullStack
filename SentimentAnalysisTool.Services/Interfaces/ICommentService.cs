using SentimentAnalysisTool.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SentimentAnalysisTool.Services.Interfaces
{
    public interface ICommentService
    {
        Task<ICollection<CommentModel>> FetchCommentsAsync(int pageSize, int pageNumber, string baseUrl, HttpClient httpClient);
        Task<bool> SaveCommentsAsync(IEnumerable<CommentModel> comments, string baseUrl, HttpClient httpClient);
        Task<bool> SaveCommentsAsync(CommentModel comment, string baseUrl, HttpClient httpClient);
    }
}
