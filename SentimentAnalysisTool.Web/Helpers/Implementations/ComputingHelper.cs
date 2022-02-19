using SentimentAnalysisTool.Data.Enums;
using SentimentAnalysisTool.Web.Helpers.Interfaces;
using SentimentAnalysisTool.Web.Models;
using System;
using System.Linq;

namespace SentimentAnalysisTool.Web.Helpers.Implementations
{
    public class ComputingHelper : IComputingHelper
    {
        public ConfusionMatrixViewModel ComputeAlgorithmnConfusionMatrix(RecordDisplayViewModel record)
        {
            var truePositives = (double)0;
            var trueNegatives = (double)0;
            var falsePositives = (double)0;
            var falseNegatives = (double)0;
            switch (record.Algorithmn)
            {
                case AlgorithmnType.SentiWordNet:
                    foreach (var item in record.CommentSentiwordModels)
                    {
                        if (item.CommentPolarity.Equals(SentimentType.Positive)
                            && item.AlgorithmnGrade.SentimentScore.Equals(SentimentType.Positive.ToString()))
                        {
                            truePositives++;
                        }
                        if (item.CommentPolarity.Equals(SentimentType.Negative)
                            && item.AlgorithmnGrade.SentimentScore.Equals(SentimentType.Negative.ToString()))
                        {
                            trueNegatives++;
                        }
                        if (item.CommentPolarity.Equals(SentimentType.Negative)
                            && item.AlgorithmnGrade.SentimentScore.Equals(SentimentType.Positive.ToString()))
                        {
                            falsePositives++;
                        }
                        if (item.CommentPolarity.Equals(SentimentType.Positive)
                            && item.AlgorithmnGrade.SentimentScore.Equals(SentimentType.Negative.ToString()))
                        {
                            falseNegatives++;
                        }
                    }
                    break;
                case AlgorithmnType.Hybrid:
                    foreach (var item in record.CommentHybridViewModels)
                    {
                        if (item.CommentPolarity.Equals(SentimentType.Positive)
                            && item.AlgorithmnGrade.HybridScore.Equals(SentimentType.Positive.ToString()))
                        {
                            truePositives++;
                        }
                        if (item.CommentPolarity.Equals(SentimentType.Negative)
                            && item.AlgorithmnGrade.HybridScore.Equals(SentimentType.Negative.ToString()))
                        {
                            trueNegatives++;
                        }
                        if (item.CommentPolarity.Equals(SentimentType.Negative)
                            && item.AlgorithmnGrade.HybridScore.Equals(SentimentType.Positive.ToString()))
                        {
                            falsePositives++;
                        }
                        if (item.CommentPolarity.Equals(SentimentType.Positive)
                            && item.AlgorithmnGrade.HybridScore.Equals(SentimentType.Negative.ToString()))
                        {
                            falseNegatives++;
                        }
                    }
                    break;
                case AlgorithmnType.Vader:
                    foreach (var item in record.CommentVaderViewModels)
                    {
                        if (item.CommentPolarity.Equals(SentimentType.Positive)
                            && item.AlgorithmnGrade.CompoundScore.Equals(SentimentType.Positive.ToString()))
                        {
                            truePositives++;
                        }
                        if (item.CommentPolarity.Equals(SentimentType.Negative)
                            && item.AlgorithmnGrade.CompoundScore.Equals(SentimentType.Negative.ToString()))
                        {
                            trueNegatives++;
                        }
                        if (item.CommentPolarity.Equals(SentimentType.Negative)
                            && item.AlgorithmnGrade.CompoundScore.Equals(SentimentType.Positive.ToString()))
                        {
                            falsePositives++;
                        }
                        if (item.CommentPolarity.Equals(SentimentType.Positive)
                            && item.AlgorithmnGrade.CompoundScore.Equals(SentimentType.Negative.ToString()))
                        {
                            falseNegatives++;
                        }
                    }
                    break;
            }
            var value = new ConfusionMatrixViewModel()
            {
                Accuracy = ((truePositives + trueNegatives) / (truePositives + trueNegatives + falsePositives + falseNegatives)) * 100,
                Precision = ((truePositives) / (truePositives + falsePositives)) * 100,
                Recall = ((truePositives) / (truePositives + falseNegatives)) * 100,
                F1_Score = ((2 * truePositives) / (2 * truePositives + falsePositives + falseNegatives)) * 100
            };
            return value;
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
