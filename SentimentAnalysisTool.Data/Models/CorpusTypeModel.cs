using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SentimentAnalysisTool.Data.Models
{
    public class CorpusTypeModel
    {
        public int CorpusTypeId { get; set; }
        public string CorpusTypeName { get; set; }
        public IEnumerable<CorpusWordModel> CorpusWords { get; set; }
        public IEnumerable<SlangRecordModel> SlangRecords { get; set; }
    }
}
