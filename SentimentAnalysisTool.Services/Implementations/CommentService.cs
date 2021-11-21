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
    public class CommentService : ICommentService
    {
        private readonly HttpClient _httpClient;
        public CommentService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public Task<IEnumerable<CommentModel>> FetchCommentsAsync(int pageSize, int pageNumber)
        {
            throw new NotImplementedException();
        }

        public Task<bool> SaveCommentsAsync(IEnumerable<CommentModel> comments)
        {
            throw new NotImplementedException();
        }

        public Task<bool> SaveCommentsAsync(CommentModel comment)
        {
            throw new NotImplementedException();
        }
    }
}
