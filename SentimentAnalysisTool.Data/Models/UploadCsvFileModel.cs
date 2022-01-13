using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using SentimentAnalysisTool.Data.Enums;

namespace SentimentAnalysisTool.Data.Models
{
    public class UploadCsvFileModel
    {
        public IFormFile File { get; set; }
        public AlgorithmnType Algorithmn { get; set; }
        public bool ShouldDeleteSlangs { get; set; }
        public bool ShouldConvertAbbreviations { get; set; }
        public bool ShouldConvertSynonyms { get; set; }
        public string CorpusType { get; set; }
        public int MaxNumberOfChars { get; set; }
        public string SubjectMatter { get; set; } = string.Empty;
    }
}
