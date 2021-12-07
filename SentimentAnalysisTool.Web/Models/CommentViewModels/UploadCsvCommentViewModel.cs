using SentimentAnalysisTool.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SentimentAnalysisTool.Web.Models.CommentViewModels
{
    public class UploadCsvCommentViewModel
    {
        public IList<CommentVaderViewModel> Vader { get; set; }
        public IList<CommentSentiWordNetViewModel> SentiWordNet { get; set; }
        public IList<CommentHybridViewModel> Hybrid { get; set; }
    }
}
