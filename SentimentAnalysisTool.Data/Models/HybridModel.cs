using Newtonsoft.Json;

namespace SentimentAnalysisTool.Data.Models
{
    public class HybridModel
    {
        /// <summary>
        /// This pertains to the value of the SentimentType
        /// </summary>
        [JsonProperty("hybridScore")]
        public string HybridScore { get; set; }
        /// <summary>
        /// This pertains to the numerical value of the computed SentimentScore
        /// </summary>
        [JsonProperty("hybridValue")]
        public double HybridValue { get; set; }
    }
}
