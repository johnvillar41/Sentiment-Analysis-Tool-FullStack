using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SentimentAnalysisTool.Web.Models
{
    public class UploadAbbreviationViewModel
    {
        public int CorpusTypeId { get; set; }
        public IFormFile File { get; set; }
    }
}
