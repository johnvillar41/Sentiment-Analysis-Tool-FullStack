using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SentimentAnalysisTool.Data.Models
{
    public class CommentModel
    {
        public int CommentId { get; set; }
        public RecordModel Record { get; set; }
        public int CommentScore { get; set; }
        public string CommentDetail { get; set; }
        public DateTime Date { get; set; }
    }
}
