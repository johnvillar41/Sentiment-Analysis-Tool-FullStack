using SentimentAnalysisTool.Data.Models;
using SentimentAnalysisTool.Web.Enums;
using System;

namespace SentimentAnalysisTool.Web.Models
{
    public class CommentVaderViewModel
    {
        public int CommentId { get; set; }
        public int CommentScore { get; set; }
        public string CommentDetail { get; set; }
        public DateTime Date { get; set; }
        public SentimentType CommentPolarity { get; set; }
        public VaderModel VaderGrade { get; set; }
        public CommentVaderViewModel(CommentModel<VaderModel> comment)
        {
            CommentId = comment.CommentId;
            CommentScore = comment.CommentScore;
            CommentDetail = comment.CommentDetail;
            Date = comment.Date;
            CommentPolarity = (SentimentType)Enum.Parse(typeof(SentimentType), comment.CommentPolarity);
            VaderGrade = comment.AlgorithmnModel;
        }
    }
}