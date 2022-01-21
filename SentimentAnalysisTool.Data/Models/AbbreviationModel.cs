using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SentimentAnalysisTool.Data.Models
{
    public class AbbreviationModel
    {
        public int AbbreviationId { get; set; }
        public CorpusTypeModel CorpusType { get; set; }
        public string Abbreviation { get; set; }
        public string AbbreviationWord { get; set; }
    }
}
