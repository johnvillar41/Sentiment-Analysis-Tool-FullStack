using SentimentAnalysisTool.Web.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SentimentAnalysisTool.Web.Models.CommentViewModels
{
    public abstract class BaseCommentViewModel
    {
        public int CommentId { get; set; }
        public int CommentScore { get; set; }
        public string CommentDetail { get; set; }
        public string TransformedCommentDetail { get; set; }
        public string ManualTransformedCommentDetail { get; set; }
        public DateTime Date { get; set; }
        public SentimentType CommentPolarity { get; set; }
        public AlgorithmnType Algorithmn { get; set; }
    }
}
