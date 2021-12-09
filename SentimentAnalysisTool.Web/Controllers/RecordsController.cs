using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using SentimentAnalysisTool.Data.Models;
using SentimentAnalysisTool.Services.Interfaces;
using SentimentAnalysisTool.Web.Enums;
using SentimentAnalysisTool.Web.Models;
using SentimentAnalysisTool.Web.Models.CommentViewModels;
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
        public async Task<IActionResult> UploadCsvFile(
            [FromForm] IFormFile file,
            [FromForm] AlgorithmnType algorithmnType)
        {
            try
            {
                RecordDisplayViewModel recordDisplay = new();
                if (algorithmnType == AlgorithmnType.Vader)
                {
                    var recordModelVaderObjects = await _recordsService.AddRecordAsync<VaderModel>(file, _configuration.GetValue<string>("BaseUrl"));
                    var recordViewModelVader = recordModelVaderObjects.CommentModels.Select(m => new CommentVaderViewModel(m));
                    recordDisplay = new RecordDisplayViewModel()
                    {
                        CommentVaderViewModels = recordViewModelVader,
                        CommentHybridViewModels = null,
                        CommentSentiwordModels = null,
                        WordFrequencyViewModels = recordModelVaderObjects.WordFrequencyModels
                            .Select(m => new WordFrequencyViewModel(m))
                            .OrderByDescending(m => m.WordFrequency)
                            .ToList(),
                    };
                    return PartialView("_RecordDisplayPartial", recordDisplay);
                }

                if (algorithmnType == AlgorithmnType.SentiWordNet)
                {
                    var recordModelSentiwordObjects = await _recordsService.AddRecordAsync<SentiWordNetModel>(file, _configuration.GetValue<string>("BaseUrl"));
                    var recordViewModelSentiwordViewModels = recordModelSentiwordObjects.CommentModels.Select(m => new CommentSentiWordNetViewModel(m));
                    recordDisplay = new RecordDisplayViewModel()
                    {
                        CommentVaderViewModels = null,
                        CommentHybridViewModels = null,
                        CommentSentiwordModels = recordViewModelSentiwordViewModels,
                        WordFrequencyViewModels = recordModelSentiwordObjects.WordFrequencyModels
                            .Select(m => new WordFrequencyViewModel(m))
                            .OrderByDescending(m => m.WordFrequency)
                            .ToList(),
                    };
                    return PartialView("_RecordDisplayPartial", recordDisplay);
                }

                if (algorithmnType == AlgorithmnType.Hybrid)
                {
                    var recordModelHybridObjects = await _recordsService.AddRecordAsync<HybridModel>(file, _configuration.GetValue<string>("BaseUrl"));
                    var recordViewModelHybridViewModels = recordModelHybridObjects.CommentModels.Select(m => new CommentHybridViewModel(m));
                    recordDisplay = new RecordDisplayViewModel()
                    {
                        CommentVaderViewModels = null,
                        CommentHybridViewModels = recordViewModelHybridViewModels,
                        CommentSentiwordModels = null,
                        WordFrequencyViewModels = recordModelHybridObjects.WordFrequencyModels
                            .Select(m => new WordFrequencyViewModel(m))
                            .OrderByDescending(m => m.WordFrequency)
                            .ToList(),
                    };
                    return PartialView("_RecordDisplayPartial", recordDisplay);
                }
                return View(nameof(Index), recordDisplay);
            }
            catch (HttpRequestException ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
