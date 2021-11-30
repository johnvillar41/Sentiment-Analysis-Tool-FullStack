using SentimentAnalysisTool.Web.Enums;
using System;

namespace SentimentAnalysisTool.Web.Models
{
    public class CommentViewModel
    {
        public int CommentId { get; set; }        
        public int CommentScore { get; set; }
        public string CommentDetail { get; set; }
        public DateTime Date { get; set; }
        public SentimentType Sentiment { get; set; }
    }
}