using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SentimentAnalysisTool.Data.Models
{
    public class VaderModel
    {       
        [JsonPropertyName("compoundScore")]
        public string CompoundScore { get; set; }

        [JsonPropertyName("compoundValue")]
        public double CompoundValue { get; set; }

        [JsonPropertyName("negativeValue")]
        public double NegativeValue { get; set; }

        [JsonPropertyName("neutralValue")]
        public double NeutralValue { get; set; }

        [JsonPropertyName("positiveValue")]
        public double PositiveValue { get; set; }        
    }
}
