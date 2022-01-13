using SentimentAnalysisTool.Data.Enums;
using SentimentAnalysisTool.Data.Models;
using System;

namespace SentimentAnalysisTool.Web.Models.CommentViewModels
{
    public class CommentSentiWordNetViewModel : BaseCommentViewModel
    {
        public SentiWordNetModel AlgorithmnGrade { get; set; }
        public CommentSentiWordNetViewModel(CommentModel<SentiWordNetModel> comment)
        {
            CommentId = comment.CommentId;
            CommentScore = comment.CommentScore;
            CommentDetail = comment.CommentDetail;
            Date = comment.Date;
            CommentPolarity = (SentimentType)Enum.Parse(typeof(SentimentType), comment.CommentPolarity);
            AlgorithmnGrade = comment.AlgorithmnModel;
            TransformedCommentDetail = comment.TransformedCommentDetail;
            Algorithmn = AlgorithmnType.SentiWordNet;
            ManualTransformedCommentDetail = comment.ManualTransformedCommentDetail;
        }
    }
}
