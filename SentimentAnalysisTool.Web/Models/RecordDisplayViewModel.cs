using SentimentAnalysisTool.Web.Models.CommentViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SentimentAnalysisTool.Web.Models
{
    public class RecordDisplayViewModel
    {
        public IEnumerable<CommentVaderViewModel> CommentVaderViewModels { get; set; } = new List<CommentVaderViewModel>(); 
        public IEnumerable<CommentHybridViewModel> CommentHybridViewModels { get; set; } = new List<CommentHybridViewModel>();
        public IEnumerable<CommentSentiWordNetViewModel> CommentSentiwordModels { get; set; } = new List<CommentSentiWordNetViewModel>();
        public IEnumerable<WordFrequencyViewModel> WordFrequencyViewModels { get; set; } = new List<WordFrequencyViewModel>();
    }
}
