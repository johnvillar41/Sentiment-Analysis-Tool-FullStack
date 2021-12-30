using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SentimentAnalysisTool.Web.Models
{
    public class ConfusionMatrixViewModel
    {
        public int Accuracy { get; set; }
        public int Precision { get; set; }
        public int Recall { get; set; }
        public int F1_Score { get; set; }
    }
}
