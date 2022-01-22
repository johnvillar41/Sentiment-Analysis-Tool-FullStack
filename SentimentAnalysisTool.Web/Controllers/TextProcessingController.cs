using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using SentimentAnalysisTool.Services.Interfaces;
using SentimentAnalysisTool.Web.Helpers;
using SentimentAnalysisTool.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace SentimentAnalysisTool.Web.Controllers
{
    public class TextProcessingController : Controller
    {
        private readonly ISlangRecordsService _slangRecordsService;
        private readonly ICorpusWordsService _corpusWordsService;
        private readonly IAbbreviationsService _abbreviationsService;
        private readonly ICorpusTypeService _corpusTypeService;
        private readonly IConfiguration _configuration;
        public string BaseUrl { get; }
        public TextProcessingController(
            ISlangRecordsService slangRecordsService,
            IConfiguration configuration,
            ICorpusWordsService corpusWordsService,
            IAbbreviationsService abbreviationsService,
            ICorpusTypeService corpusTypeService)
        {
            _slangRecordsService = slangRecordsService;
            _configuration = configuration;
            BaseUrl = _configuration.GetValue<string>("BaseUrl");
            _corpusWordsService = corpusWordsService;
            _abbreviationsService = abbreviationsService;
            _corpusTypeService = corpusTypeService;
        }

        public async Task<IActionResult> Index()
        {
            var corpusTypes = await _corpusTypeService.FetchCorpusTypesAsync(BaseUrl);
            return View(new TextProcessingViewModel() { CorpusTypes = corpusTypes });
        }

        public async Task<IActionResult> LoadCorpusTypeData([FromQuery] int corpusTypeId)
        {
            var corpusTypes = await _corpusTypeService.FetchCorpusTypesAsync(BaseUrl);
            var slangs = await _slangRecordsService.FetchAllSlangRecordAsync(corpusTypeId, BaseUrl);
            var corpuses = await _corpusWordsService.FetchCorpusWordsAsync(corpusTypeId, BaseUrl);
            var abbreviations = await _abbreviationsService.FetchAbbreviationsAsync(corpusTypeId, BaseUrl);
            var textProcessingModel = new TextProcessingViewModel()
            {
                Abbreviations = abbreviations,
                SlangRecords = slangs,
                Corpuses = corpuses,
                CorpusTypes = corpusTypes
            };

            return PartialView("_CorpusDataPartial", textProcessingModel);
        }
    }
}
