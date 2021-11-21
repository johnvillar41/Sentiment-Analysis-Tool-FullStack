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
        public async Task<ICollection<CommentModel>> FetchCommentsAsync(int pageSize, int pageNumber, string baseUrl, HttpClient httpClient)
        {
            var response = await httpClient.GetAsync($"{baseUrl}/api/Comment/{pageSize}/{pageNumber}");
            response.EnsureSuccessStatusCode();

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsAsync<ICollection<CommentModel>>();
            }
            return new List<CommentModel>();
        }

        public Task<bool> SaveCommentsAsync(IEnumerable<CommentModel> comments, string baseUrl, HttpClient httpClient)
        {
            throw new NotImplementedException();
        }

        public Task<bool> SaveCommentsAsync(CommentModel comment, string baseUrl, HttpClient httpClient)
        {
            throw new NotImplementedException();
        }
    }
}
