using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SentimentAnalysisTool.Web.Models
{
    public class UploadCsvFileModel
    {
        public IFormFile File { get; set; }

        [JsonProperty("algorithmn")]
        public string Algorithmn { get; set; }

        [JsonProperty("shouldDeleteSlangs")]
        public bool ShouldDeleteSlangs { get; set; }

        [JsonProperty("shouldConvertAbbreviations")]
        public bool ShouldConvertAbbreviations { get; set; }

        [JsonProperty("shouldConvertSynonyms")]
        public bool ShouldConvertSynonyms { get; set; }

        [JsonProperty("corpusType")]
        public string CorpusType { get; set; }

        [JsonProperty("maxNumberOfChars")]
        public int MaxNumberOfChars { get; set; }
    }
}
