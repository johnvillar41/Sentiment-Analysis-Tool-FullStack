using Newtonsoft.Json;

namespace SentimentAnalysisTool.Data.Models
{
    public class VaderModel
    {       
        [JsonProperty("compoundScore")]
        public string CompoundScore { get; set; }

        [JsonProperty("compoundValue")]
        public double CompoundValue { get; set; }

        [JsonProperty("negativeValue")]
        public double NegativeValue { get; set; }

        [JsonProperty("neutralValue")]
        public double NeutralValue { get; set; }

        [JsonProperty("positiveValue")]
        public double PositiveValue { get; set; }        
    }
}
