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
        public IEnumerable<CorpusWordModel> CorpusWordModels { get; set; } = new List<CorpusWordModel>();
        public IEnumerable<SlangRecordModel> SlangRecordModels { get; set; } = new List<SlangRecordModel>();
    }
}
