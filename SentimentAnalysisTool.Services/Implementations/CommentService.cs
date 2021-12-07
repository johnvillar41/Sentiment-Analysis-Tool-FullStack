using Microsoft.AspNetCore.Http;
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
        public async Task<ICollection<CommentModel<T>>> FetchCommentsAsync<T>(int pageSize, int pageNumber, string baseUrl, HttpClient httpClient)
        {
            var response = await httpClient.GetAsync($"{baseUrl}/api/Comment/{pageSize}/{pageNumber}");
            var responseCode = response.EnsureSuccessStatusCode();

            if (responseCode.IsSuccessStatusCode)
                return await response.Content.ReadAsAsync<ICollection<CommentModel<T>>>();

            return new List<CommentModel<T>>();
        }

        public async Task<bool> UploadCsvFileAsync(IFormFile csv, string baseUrl, HttpClient httpClient)
        {
            throw new NotImplementedException();
            //TODO 
        }
    }
}
