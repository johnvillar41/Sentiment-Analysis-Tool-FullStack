using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SentimentAnalysisTool.Data.Models
{
    public class CommentModel<T>
    {
        public int CommentId { get; set; }
        public int RecordId { get; set; }
        public int CommentScore { get; set; }
        public string CommentDetail { get; set; }
        public DateTime Date { get; set; }
        public int PolarityScore { get; set; }
        T AlgorithmnModel { get; set; }
    }

}
