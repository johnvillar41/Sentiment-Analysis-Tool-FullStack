using SentimentAnalysisTool.Data.Models;
using SentimentAnalysisTool.Web.Enums;
using System;
using System.Text.Json.Serialization;

namespace SentimentAnalysisTool.Web.Models.CommentViewModels
{
    public class CommentVaderViewModel : BaseCommentViewModel
    {
        public VaderModel VaderGrade { get; set; }
        public CommentVaderViewModel(CommentModel<VaderModel> comment)
        {
            CommentId = comment.CommentId;
            CommentScore = comment.CommentScore;
            CommentDetail = comment.CommentDetail;
            Date = comment.Date;
            CommentPolarity = (SentimentType)Enum.Parse(typeof(SentimentType), comment.CommentPolarity);
            VaderGrade = comment.AlgorithmnModel;
            TransformedCommentDetail = comment.TransformedCommentDetail;
        }
    }
}