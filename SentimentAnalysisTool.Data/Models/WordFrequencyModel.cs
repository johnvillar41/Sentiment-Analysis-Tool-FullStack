using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SentimentAnalysisTool.Data.Models
{
    public class WordFrequencyModel
    {
        public int WordFrequencyId { get; set; }
        public int RecordId { get; set; }
        public string Word { get; set; }
        public int WordFrequency { get; set; }
    }
}
