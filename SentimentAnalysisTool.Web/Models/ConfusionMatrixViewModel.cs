using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SentimentAnalysisTool.Web.Models
{
    public class ConfusionMatrixViewModel
    {
        public double Accuracy { get; set; } = 0.0;
        public double Precision { get; set; } = 0.0;

        private double _recall;
        public double Recall
        {
            get
            {
                if (Double.IsNaN(_recall))
                {
                    _recall = 0.0;
                }

                return _recall;
            }
            set
            {
                _recall = value;
            }
        }
        public double F1_Score { get; set; } = 0.0;
    }
}
