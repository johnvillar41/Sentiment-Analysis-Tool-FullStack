using Microsoft.AspNetCore.Http;
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
            ViewBag.CorpusTypeId = corpusTypes.FirstOrDefault().CorpusTypeId;
            return View(new TextProcessingViewModel() { CorpusTypes = corpusTypes });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UploadSlangTextFile([FromForm] UploadSlangFileViewModel slangFile)
        {
            if (slangFile == null)
                return BadRequest();

            _ = await _slangRecordsService.AddSlangRecordsAsync(slangFile.File, slangFile.CorpusTypeId, BaseUrl);
            var slangs = await _slangRecordsService.FetchAllSlangRecordAsync(slangFile.CorpusTypeId, BaseUrl);
            ViewBag.CorpusTypeId = slangFile.CorpusTypeId;
            return PartialView("_SlangRecordPartial", slangs);
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
            ViewBag.CorpusTypeId = corpusTypeId;
            return PartialView("_CorpusDataPartial", textProcessingModel);
        }

        public async Task<IActionResult> DeleteSlangRecord([FromQuery] int corpusTypeId, [FromQuery] int slangRecordId)
        {
            ViewBag.CorpusTypeId = corpusTypeId;
            var result = await _slangRecordsService.DeleteSlangRecordAsync(slangRecordId, BaseUrl);
            if (result)
            {
                var slangs = await _slangRecordsService.FetchAllSlangRecordAsync(corpusTypeId, BaseUrl);
                return PartialView("_SlangRecordPartial", slangs);
            }

            return BadRequest("An error has occured!");
        }

        public async Task<IActionResult> DeleteAbbreviation([FromQuery] int corpusTypeId, [FromQuery] int abbreviationId)
        {
            ViewBag.CorpusTypeId = corpusTypeId;
            var result = await _abbreviationsService.DeleteAbbreviationAsync(abbreviationId, BaseUrl);
            if (result)
            {
                var abbreviations = await _abbreviationsService.FetchAbbreviationsAsync(corpusTypeId, BaseUrl);
                return PartialView("_AbbreviationPartial", abbreviations);
            }

            return BadRequest("An error has occured!");
        }

        public async Task<IActionResult> DeleteCorpusWord([FromQuery] int corpusTypeId, [FromQuery] int corpusWordId)
        {
            ViewBag.CorpusTypeId = corpusTypeId;
            var result = await _corpusWordsService.DeleteCorpusWordAsync(corpusWordId, BaseUrl);
            if (result)
            {
                var corpuses = await _corpusWordsService.FetchCorpusWordsAsync(corpusTypeId, BaseUrl);
                return PartialView("_CorpusWordPartial", corpuses);
            }

            return BadRequest("An error has occured!");
        }
    }
}
