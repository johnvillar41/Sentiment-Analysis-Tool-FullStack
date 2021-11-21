using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SentimentAnalysisTool.Data.Models
{
    public class CorpusRecordModel
    {
        public int CorpusRecordId { get; set; }
        public RecordModel Record { get; set; }
        public CorpusTypeModel CorpusType { get; set; }
    }
}
