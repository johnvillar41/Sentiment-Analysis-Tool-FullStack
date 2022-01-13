using SentimentAnalysisTool.Data.Enums;
using SentimentAnalysisTool.Web.Models.CommentViewModels;
using System.Collections.Generic;

namespace SentimentAnalysisTool.Web.Models
{
    public class RecordDisplayViewModel
    {
        public IEnumerable<CommentVaderViewModel> CommentVaderViewModels { get; set; } 
        public IEnumerable<CommentHybridViewModel> CommentHybridViewModels { get; set; }
        public IEnumerable<CommentSentiWordNetViewModel> CommentSentiwordModels { get; set; }
        public IEnumerable<WordFrequencyViewModel> WordFrequencyViewModels { get; set; }
        public IEnumerable<CommentTransformViewModel> CommentTransformViewModels { get; set; }
        public int TotalNumberOfCommentRows { get; set; }
        public int TotalNumberOfAcceptedCommentRows { get; set; }
        public ReviewClassficationViewModel ReviewClassification { get; set; }
        public AlgorithmnType? Algorithmn { get; set; }
    }
}
