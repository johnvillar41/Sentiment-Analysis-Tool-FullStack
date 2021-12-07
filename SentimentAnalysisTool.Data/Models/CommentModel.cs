using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SentimentAnalysisTool.Data.Models
{    
    public class CommentModel<T>
    {
        [JsonPropertyName("commentId")]
        public int CommentId { get; set; }

        [JsonPropertyName("recordId")]
        public int RecordId { get; set; }

        [JsonPropertyName("commentScore")]
        public int CommentScore { get; set; }

        [JsonPropertyName("commentPolarity")]
        public string CommentPolarity { get; set; }

        [JsonPropertyName("commentDetail")]
        public string CommentDetail { get; set; }

        [JsonPropertyName("date")]
        public DateTime Date { get; set; }

        [JsonPropertyName("algorithmnObject")]
        T AlgorithmnModel { get; set; }
    }

}
