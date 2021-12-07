using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SentimentAnalysisTool.Data.Models
{
    public class SentiWordNetModel
    {        
        [JsonPropertyName("polarityScore")]
        public double PolarityScore { get; set; }

        [JsonPropertyName("positiveScore")]
        public double PositiveScore { get; set; }

        [JsonPropertyName("negativeScore")]
        public double NegativeScore { get; set; }

        [JsonPropertyName("sentimentScore")]
        public string SentimentScore { get; set; }
    }
}
