using SentimentAnalysisTool.Data.Enums;
using SentimentAnalysisTool.Data.Models;
using System;

namespace SentimentAnalysisTool.Web.Models.CommentViewModels
{
    public class CommentHybridViewModel : BaseCommentViewModel
    {
        public HybridModel AlgorithmnGrade { get; set; }
        public CommentHybridViewModel(CommentModel<HybridModel> comment)
        {
            CommentId = comment.CommentId;
            CommentScore = comment.CommentScore;
            CommentDetail = comment.CommentDetail;
            Date = comment.Date;
            CommentPolarity = (SentimentType)Enum.Parse(typeof(SentimentType), comment.CommentPolarity);
            AlgorithmnGrade = comment.AlgorithmnModel;
            TransformedCommentDetail = comment.TransformedCommentDetail;
            Algorithmn = AlgorithmnType.Hybrid;
            ManualTransformedCommentDetail = comment.ManualTransformedCommentDetail;
        }
    }
}
