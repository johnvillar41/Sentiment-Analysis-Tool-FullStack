using SentimentAnalysisTool.Data.Enums;
using System;

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
