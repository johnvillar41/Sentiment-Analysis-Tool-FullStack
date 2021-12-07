using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SentimentAnalysisTool.Data.Models
{
    public class RecordModel<T>
    {
        public int RecordId { get; set; }
        public string RecordName { get; set; }
        public int PositivePercent { get; set; }
        public int NegativePercent { get; set; }
        public IEnumerable<CommentModel<T>> CommentModels { get; set; }
        public IEnumerable<CorpusRecordModel> CorpusRecordModels { get; set; }
        public IEnumerable<WordFrequencyModel> WordFrequencyModels { get; set; }
    }
}
