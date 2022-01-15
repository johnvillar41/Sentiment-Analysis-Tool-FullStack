using SentimentAnalysisTool.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SentimentAnalysisTool.Web.Models
{
    public class TextProcessingViewModel
    {
        public IEnumerable<SlangRecordModel> SlangRecords { get; set; }
        public IEnumerable<AbbreviationModel> Abbreviations { get; set; }
        public IEnumerable<CorpusWordModel> Corpuses { get; set; }
    }
}
