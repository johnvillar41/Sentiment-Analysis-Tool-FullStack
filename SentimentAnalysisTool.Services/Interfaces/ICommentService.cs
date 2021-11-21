using SentimentAnalysisTool.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SentimentAnalysisTool.Services.Interfaces
{
    public interface ICommentService
    {
        Task<IEnumerable<CommentModel>> FetchCommentsAsync(int pageSize, int pageNumber);
        Task<bool> SaveCommentsAsync(IEnumerable<CommentModel> comments);
        Task<bool> SaveCommentsAsync(CommentModel comment);
    }
}
