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
        public int CorpusTypeId { get; set; }
        public string CorpusWord { get; set; }
    }
}
