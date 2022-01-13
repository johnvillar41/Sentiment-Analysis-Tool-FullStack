using SentimentAnalysisTool.Data.Enums;
using SentimentAnalysisTool.Data.Models;
using System;

namespace SentimentAnalysisTool.Web.Models.CommentViewModels
{
    public class CommentVaderViewModel : BaseCommentViewModel
    {
        public VaderModel AlgorithmnGrade { get; set; }
        public CommentVaderViewModel(CommentModel<VaderModel> comment)
        {
            CommentId = comment.CommentId;
            CommentScore = comment.CommentScore;
            CommentDetail = comment.CommentDetail;
            Date = comment.Date;
            CommentPolarity = (SentimentType)Enum.Parse(typeof(SentimentType), comment.CommentPolarity);
            AlgorithmnGrade = comment.AlgorithmnModel;
            TransformedCommentDetail = comment.TransformedCommentDetail;
            Algorithmn = AlgorithmnType.Vader;
            ManualTransformedCommentDetail = comment.ManualTransformedCommentDetail;
        }
    }
}