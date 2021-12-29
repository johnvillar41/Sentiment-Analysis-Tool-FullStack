using SentimentAnalysisTool.Web.Models.CommentViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SentimentAnalysisTool.Web.Models
{
    public class CommentTransformViewModel
    {
        private string _manualTransformedComment;
        private string _automaticTransformedComment;

        public string OriginalComment { get; set; }
        public string ManualTransformedComment 
        { 
            get => _manualTransformedComment.Trim(); 
            set => _manualTransformedComment = value; 
        }
        public string AutomaticTransformedComment 
        {
            get => _automaticTransformedComment.Trim();
            set => _automaticTransformedComment = value;
        }
        public bool IsCommentEqual { get; }
        public CommentTransformViewModel(BaseCommentViewModel comment)
        {
            OriginalComment = comment.CommentDetail;
            ManualTransformedComment = comment.ManualTransformedCommentDetail;
            AutomaticTransformedComment = comment.TransformedCommentDetail;
            IsCommentEqual = ManualTransformedComment.Equals(AutomaticTransformedComment, StringComparison.OrdinalIgnoreCase);
        }
        public CommentTransformViewModel()
        {

        }
    }
}
