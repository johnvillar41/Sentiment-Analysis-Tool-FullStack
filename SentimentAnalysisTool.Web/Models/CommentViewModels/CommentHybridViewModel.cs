using Newtonsoft.Json;
using SentimentAnalysisTool.Data.Models;
using SentimentAnalysisTool.Web.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

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
