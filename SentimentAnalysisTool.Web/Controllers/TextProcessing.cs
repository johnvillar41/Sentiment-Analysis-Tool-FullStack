using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using SentimentAnalysisTool.Services.Interfaces;
using SentimentAnalysisTool.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace SentimentAnalysisTool.Web.Controllers
{
    public class TextProcessing : Controller
    {
        private readonly ISlangRecordsService _slangRecordsService;
        private readonly ICorpusWordsService _corpusWordsService;
        private readonly IAbbreviationsService _abbreviationsService;
        private readonly IConfiguration _configuration;
        public string BaseUrl { get; }
        public TextProcessing(
            ISlangRecordsService slangRecordsService,
            IConfiguration configuration,
            ICorpusWordsService corpusWordsService,
            IAbbreviationsService abbreviationsService)
        {
            _slangRecordsService = slangRecordsService;
            _configuration = configuration;
            BaseUrl = _configuration.GetValue<string>("BaseUrl");
            _corpusWordsService = corpusWordsService;
            _abbreviationsService = abbreviationsService;
        }
        public async Task<IActionResult> Index(int? corpusTypeId)
        {
            if (corpusTypeId == null)
                return View(new TextProcessingViewModel());

            var slangs = await _slangRecordsService.FetchAllSlangRecordAsync(corpusTypeId, BaseUrl);
            var corpuses = await _corpusWordsService.FetchCorpusWordsAsync(corpusTypeId, BaseUrl);
            var abbreviations = await _abbreviationsService.FetchAbbreviationsAsync(corpusTypeId, BaseUrl);
            var textProcessingModel = new TextProcessingViewModel()
            {
                Abbreviations = abbreviations,
                SlangRecords = slangs,
                Corpuses = corpuses
            };
            return View(textProcessingModel);
        }
    }
}
