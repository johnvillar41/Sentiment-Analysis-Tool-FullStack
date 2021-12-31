using SentimentAnalysisTool.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SentimentAnalysisTool.Web.Helpers.Interfaces
{
    public interface IComputingHelper
    {
        double ComputeTextProcessingAccuracy(RecordDisplayViewModel record);
        double ComputeAlgorithmnAccuracy(RecordDisplayViewModel record);
    }
}
