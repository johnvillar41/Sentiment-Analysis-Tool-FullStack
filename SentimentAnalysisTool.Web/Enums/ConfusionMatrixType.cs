using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SentimentAnalysisTool.Web.Enums
{
    public enum ConfusionMatrixType
    {
        /// <summary>
        /// True Positive
        /// </summary>
        TP,

        /// <summary>
        /// True Negative
        /// </summary>
        TN,

        /// <summary>
        /// False Positive
        /// </summary>
        FP,

        /// <summary>
        /// False Negative
        /// </summary>
        FN
    }
}
