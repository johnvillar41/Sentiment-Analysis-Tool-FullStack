using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using SentimentAnalysisTool.Data.Models;
using SentimentAnalysisTool.Services.Interfaces;
using SentimentAnalysisTool.Web.Enums;
using SentimentAnalysisTool.Web.Helpers;
using SentimentAnalysisTool.Web.Models;
using SentimentAnalysisTool.Web.Models.CommentViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace SentimentAnalysisTool.Web.Controllers
{
    public class RecordsController : Controller
    {
        private readonly IRecordsService _recordsService;
        private readonly IConfiguration _configuration;

        public RecordsController(
            IRecordsService recordsService,
            IConfiguration configuration)
        {
            _recordsService = recordsService;
            _configuration = configuration;
        }

        public IActionResult Index(RecordDisplayViewModel model)
        {
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> UploadCsvFile(
            [FromForm] IFormFile file,
            [FromForm] AlgorithmnType algorithmnType,
            [FromForm] bool shouldDeleteSlangs,
            [FromForm] bool shouldConvertAbbreviations,
            [FromForm] string corpusType,
            [FromForm] int maxNumberOfChars)
        {
            try
            {
                var uploadCsvModel = new UploadCsvFileModel()
                {
                    File = file,
                    ShouldDeleteSlangs = shouldDeleteSlangs,
                    ShouldConvertAbbreviations = shouldConvertAbbreviations,
                    CorpusType = corpusType,
                    MaxNumberOfChars = maxNumberOfChars,
                    Algorithmn = algorithmnType.ToString()
                };
                RecordDisplayViewModel recordDisplay = new();
                recordDisplay = await BuildRecordDisplayViewModelAsync(uploadCsvModel, recordDisplay, algorithmnType);

                var obj = new
                {
                    Html = await RenderHelper.RenderViewAsync<RecordDisplayViewModel>(this, "_RecordDisplayPartial", recordDisplay),
                    recordDisplay.ReviewClassification
                };
                return Json(obj);
            }
            catch (HttpRequestException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        private async Task<RecordDisplayViewModel> BuildRecordDisplayViewModelAsync(UploadCsvFileModel record, RecordDisplayViewModel recordDisplay, AlgorithmnType algorithmn)
        {
            switch (algorithmn)
            {
                case AlgorithmnType.Hybrid:
                    var recordModelHybridObjects = await _recordsService.AddRecordAsync<HybridModel>(record, _configuration.GetValue<string>("BaseUrl"));
                    var recordViewModelHybridViewModels = recordModelHybridObjects.CommentModels.Select(m => new CommentHybridViewModel(m));
                    recordDisplay = new RecordDisplayViewModel()
                    {
                        CommentHybridViewModels = recordViewModelHybridViewModels,
                        ReviewClassification = new ReviewClassficationViewModel(recordModelHybridObjects.PositivePercent, recordModelHybridObjects.NegativePercent),
                        WordFrequencyViewModels = recordModelHybridObjects.WordFrequencyModels
                            .Select(m => new WordFrequencyViewModel(m))
                            .OrderByDescending(m => m.WordFrequency)
                            .ToList(),
                        CommentTransformViewModels = recordViewModelHybridViewModels.Select(m => new CommentTransformViewModel(m)).ToList()
                    };
                    break;
                case AlgorithmnType.SentiWordNet:
                    var recordModelSentiwordObjects = await _recordsService.AddRecordAsync<SentiWordNetModel>(record, _configuration.GetValue<string>("BaseUrl"));
                    var recordViewModelSentiwordViewModels = recordModelSentiwordObjects.CommentModels.Select(m => new CommentSentiWordNetViewModel(m));
                    recordDisplay = new RecordDisplayViewModel()
                    {
                        CommentSentiwordModels = recordViewModelSentiwordViewModels,
                        ReviewClassification = new ReviewClassficationViewModel(recordModelSentiwordObjects.PositivePercent, recordModelSentiwordObjects.NegativePercent),
                        WordFrequencyViewModels = recordModelSentiwordObjects.WordFrequencyModels
                            .Select(m => new WordFrequencyViewModel(m))
                            .OrderByDescending(m => m.WordFrequency)
                            .ToList(),
                        CommentTransformViewModels = recordViewModelSentiwordViewModels.Select(m=> new CommentTransformViewModel(m)).ToList()
                    };
                    break;
                case AlgorithmnType.Vader:
                    var recordModelVaderObjects = await _recordsService.AddRecordAsync<VaderModel>(record, _configuration.GetValue<string>("BaseUrl"));
                    var recordViewModelVader = recordModelVaderObjects.CommentModels.Select(m => new CommentVaderViewModel(m));
                    recordDisplay = new RecordDisplayViewModel()
                    {
                        CommentVaderViewModels = recordViewModelVader,
                        ReviewClassification = new ReviewClassficationViewModel(recordModelVaderObjects.PositivePercent, recordModelVaderObjects.NegativePercent),
                        WordFrequencyViewModels = recordModelVaderObjects.WordFrequencyModels
                            .Select(m => new WordFrequencyViewModel(m))
                            .OrderByDescending(m => m.WordFrequency)
                            .ToList(),
                        CommentTransformViewModels = recordViewModelVader.Select(m => new CommentTransformViewModel(m)).ToList()
                    };
                    break;
            }
            recordDisplay.Algorithmn = algorithmn;
            return recordDisplay;
        }
    }
}
