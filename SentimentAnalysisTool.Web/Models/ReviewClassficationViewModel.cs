using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SentimentAnalysisTool.Web.Models
{
    public class ReviewClassficationViewModel
    {
        [JsonPropertyName("positivePercent")]
        public int? PositivePercent { get; set; } = 0;

        [JsonPropertyName("negativePercent")]
        public int? NegativePercent { get; set; } = 0;
        public ReviewClassficationViewModel(int positivePercent, int negativePercent)
        {
            PositivePercent = positivePercent;
            NegativePercent = negativePercent;
        }
        public ReviewClassficationViewModel()
        {

        }
    }
}
