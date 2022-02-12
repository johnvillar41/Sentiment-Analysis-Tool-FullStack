using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SentimentAnalysisTool.Web.Models.UploadTextProcessingViewModels
{
    public abstract class UploadTextProcessingViewModel
    {
        public IFormFile File { get; set; }
        public int CorpusTypeId { get; set; }
    }
}
