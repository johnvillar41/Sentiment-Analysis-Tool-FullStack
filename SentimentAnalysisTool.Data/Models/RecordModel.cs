using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SentimentAnalysisTool.Data.Models
{
    public class RecordModel
    {
        public int RecordId { get; set; }
        public string RecordName { get; set; }
        public int PositivePercent { get; set; }
        public int NegativePercent { get; set; }
    }
}
