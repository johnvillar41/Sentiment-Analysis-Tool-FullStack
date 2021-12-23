using Newtonsoft.Json;
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
        [JsonProperty("commentId")]
        public int CommentId { get; set; }

        [JsonProperty("recordId")]
        public int RecordId { get; set; }

        [JsonProperty("commentScore")]
        public int CommentScore { get; set; }

        [JsonProperty("commentPolarity")]
        public string CommentPolarity { get; set; }

        [JsonProperty("commentDetail")]
        public string CommentDetail { get; set; }

        [JsonProperty("date")]
        public DateTime Date { get; set; }
        
        [JsonProperty("algorithmnModel")]
        public T AlgorithmnModel { get; set; }        
    }

}
