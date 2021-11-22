using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SentimentAnalysisTool.Data.Models
{
    public class CorpusRecordModel
    {
        public int CorpusRecordsId { get; set; }
        public int RecordId { get; set; }
        public int CorpusTypeId { get; set; }
    }
}
