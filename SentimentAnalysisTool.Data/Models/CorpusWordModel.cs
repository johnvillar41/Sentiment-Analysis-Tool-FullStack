using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SentimentAnalysisTool.Data.Models
{
    public class CorpusWordModel
    {
        public int CorpusWordId { get; set; }
        public CorpusTypeModel CorpusType { get; set; }
        public string CorpusWord { get; set; }
        public string SynonymWord { get; set; }
    }
}
