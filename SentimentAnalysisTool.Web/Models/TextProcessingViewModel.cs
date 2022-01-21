using SentimentAnalysisTool.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SentimentAnalysisTool.Web.Models
{
    public class TextProcessingViewModel
    {
        public IEnumerable<SlangRecordModel> SlangRecords { get; set; } = new List<SlangRecordModel>();
        public IEnumerable<AbbreviationModel> Abbreviations { get; set; } = new List<AbbreviationModel>();
        public IEnumerable<CorpusWordModel> Corpuses { get; set; } = new List<CorpusWordModel>();
    }
}
