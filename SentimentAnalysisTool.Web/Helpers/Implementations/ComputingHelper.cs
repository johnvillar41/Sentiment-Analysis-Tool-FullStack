using SentimentAnalysisTool.Web.Enums;
using SentimentAnalysisTool.Web.Helpers.Interfaces;
using SentimentAnalysisTool.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SentimentAnalysisTool.Web.Helpers.Implementations
{
    public class ComputingHelper : IComputingHelper
    {
        public double ComputeAlgorithmnAccuracy(RecordDisplayViewModel record)
        {
            var totalComments = (double)0;
            var totalPositiveEquals = (double)0;
            switch (record.Algorithmn)
            {
                case AlgorithmnType.SentiWordNet:
                    totalComments = (double)record.CommentSentiwordModels.Count();
                    totalPositiveEquals = (double)0;
                    foreach (var item in record.CommentSentiwordModels)
                    {
                        if (item.AlgorithmnGrade.SentimentScore
                            .Trim()
                            .Equals(item.CommentPolarity.ToString()))
                        {
                            totalPositiveEquals++;
                        }
                    }
                    break;
                case AlgorithmnType.Vader:
                    totalComments = (double)record.CommentVaderViewModels.Count();
                    totalPositiveEquals = (double)0;
                    foreach (var item in record.CommentVaderViewModels)
                    {
                        if (item.AlgorithmnGrade.CompoundScore
                            .Trim()
                            .Equals(item.CommentPolarity.ToString()))
                        {
                            totalPositiveEquals++;
                        }
                    }
                    break;
                case AlgorithmnType.Hybrid:
                    totalComments = (double)record.CommentHybridViewModels.Count();
                    totalPositiveEquals = (double)0;
                    foreach (var item in record.CommentHybridViewModels)
                    {
                        if (item.AlgorithmnGrade.HybridScore
                            .Trim()
                            .Equals(item.CommentPolarity.ToString()))
                        {
                            totalPositiveEquals++;
                        }
                    }
                    break;

            }
            return (totalPositiveEquals / totalComments) * 100;
        }

        public double ComputeTextProcessingAccuracy(RecordDisplayViewModel record)
        {
            var totalComments = (double)0;
            var totalPositiveEquals = (double)0;
            switch (record.Algorithmn)
            {
                case AlgorithmnType.SentiWordNet:
                    totalComments = (double)record.CommentSentiwordModels.Count();
                    totalPositiveEquals = (double)0;
                    foreach (var item in record.CommentSentiwordModels)
                    {
                        if (item.ManualTransformedCommentDetail
                            .Trim()
                            .Equals(item.TransformedCommentDetail))
                        {
                            totalPositiveEquals++;
                        }
                    }
                    break;
                case AlgorithmnType.Vader:
                    totalComments = (double)record.CommentVaderViewModels.Count();
                    totalPositiveEquals = (double)0;
                    foreach (var item in record.CommentVaderViewModels)
                    {
                        if (item.ManualTransformedCommentDetail
                           .Trim()
                           .Equals(item.TransformedCommentDetail))
                        {
                            totalPositiveEquals++;
                        }
                    }
                    break;
                case AlgorithmnType.Hybrid:
                    totalComments = (double)record.CommentHybridViewModels.Count();
                    totalPositiveEquals = (double)0;
                    foreach (var item in record.CommentHybridViewModels)
                    {
                        if (item.ManualTransformedCommentDetail
                           .Trim()
                           .Equals(item.TransformedCommentDetail))
                        {
                            totalPositiveEquals++;
                        }
                    }
                    break;

            }
            return (totalPositiveEquals / totalComments) * 100;
        }
    }
}
