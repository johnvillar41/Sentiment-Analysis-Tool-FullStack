using Newtonsoft.Json;

namespace SentimentAnalysisTool.Data.Models
{
    public class SentiWordNetModel
    {        
        [JsonProperty("polarityScore")]
        public double PolarityScore { get; set; }

        [JsonProperty("positiveScore")]
        public double PositiveScore { get; set; }

        [JsonProperty("negativeScore")]
        public double NegativeScore { get; set; }

        [JsonProperty("sentimentScore")]
        public string SentimentScore { get; set; }
    }
}
