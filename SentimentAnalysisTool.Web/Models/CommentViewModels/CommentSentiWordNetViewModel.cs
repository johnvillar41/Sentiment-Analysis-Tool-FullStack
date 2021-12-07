using SentimentAnalysisTool.Data.Models;
using SentimentAnalysisTool.Web.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SentimentAnalysisTool.Web.Models.CommentViewModels
{
    public class CommentSentiWordNetViewModel : BaseCommentViewModel
    {        
        public SentiWordNetModel SentiWordNetGrade { get; set; }
        public CommentSentiWordNetViewModel(CommentModel<SentiWordNetModel> comment)
        {
            CommentId = comment.CommentId;
            CommentScore = comment.CommentScore;
            CommentDetail = comment.CommentDetail;
            Date = comment.Date;
            CommentPolarity = (SentimentType)Enum.Parse(typeof(SentimentType), comment.CommentPolarity);
            SentiWordNetGrade = comment.AlgorithmnModel;
        }
    }
}
