using SentimentAnalysisTool.Web.Models.CommentViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SentimentAnalysisTool.Web.Models
{
    public class CommentTransformViewModel
    {
        public string OriginalComment { get; set; }
        public string ManualTransformedComment { get; set; }
        public string AutomaticTransformedComment { get; set; }
        public bool IsCommentEqual { get; }
        public CommentTransformViewModel(BaseCommentViewModel comment)
        {
            OriginalComment = comment.CommentDetail;
            ManualTransformedComment = comment.TransformedCommentDetail; // TODO
            AutomaticTransformedComment = comment.TransformedCommentDetail;
            IsCommentEqual = ManualTransformedComment.Equals(AutomaticTransformedComment);
        }
        public CommentTransformViewModel()
        {

        }
    }
}
