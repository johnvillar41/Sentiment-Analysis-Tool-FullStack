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
                return await response.Content.ReadAsAsync<ICollection<CommentModel>>();

            return new List<CommentModel>();
        }

        public async Task<bool> SaveCommentsAsync(IEnumerable<CommentModel> comments, string baseUrl, HttpClient httpClient)
        {
            var response = await httpClient.PostAsJsonAsync<IEnumerable<CommentModel>>($"{baseUrl}/api/Comment", comments);
            if (response.IsSuccessStatusCode)
                return true;

            return false;
        }

        public async Task<bool> SaveCommentsAsync(CommentModel comment, string baseUrl, HttpClient httpClient)
        {
            var response = await httpClient.PostAsJsonAsync<CommentModel>($"{baseUrl}/api/Comment", comment);
            if (response.IsSuccessStatusCode)
                return true;

            return false;
        }
    }
}
