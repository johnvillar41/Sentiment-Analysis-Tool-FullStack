using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using SentimentAnalysisTool.Data.Models;
using SentimentAnalysisTool.Services.Interfaces;
using SentimentAnalysisTool.Web.Enums;
using SentimentAnalysisTool.Web.Models.CommentViewModels;
using System.Collections.Generic;
using System.Linq;
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

        public IActionResult Index(UploadCsvCommentViewModel model)
        {
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UploadCsvFile(
            [FromForm] IFormFile file,
            [FromForm] AlgorithmnType algorithmnType)
        {
            UploadCsvCommentViewModel uploadCsvCommentViewModel = null;
            if (algorithmnType == AlgorithmnType.Vader)
            {
                var commentVaderObject = await _recordsService.AddRecordAsync<VaderModel>(file, _configuration.GetValue<string>("BaseUrl"));
                var commentViewModelsVader = commentVaderObject.Select(m => new CommentVaderViewModel(m)).ToList();
                uploadCsvCommentViewModel = new UploadCsvCommentViewModel()
                {
                    Vader = commentViewModelsVader,
                    SentiWordNet = null,
                    Hybrid = null
                };
            }

            if (algorithmnType == AlgorithmnType.SentiWordNet)
            {
                var commentVaderObject = await _recordsService.AddRecordAsync<SentiWordNetModel>(file, _configuration.GetValue<string>("BaseUrl"));
                var commentViewModelsSentiWordnet = commentVaderObject.Select(m => new CommentSentiWordNetViewModel(m)).ToList();
                uploadCsvCommentViewModel = new UploadCsvCommentViewModel()
                {
                    Vader = null,
                    SentiWordNet = commentViewModelsSentiWordnet,
                    Hybrid = null
                };
            }

            if (algorithmnType == AlgorithmnType.Hybrid)
            {
                var commentVaderObject = await _recordsService.AddRecordAsync<HybridModel>(file, _configuration.GetValue<string>("BaseUrl"));
                var commentViewModelsHybrid = commentVaderObject.Select(m => new CommentHybridViewModel(m)).ToList();
                uploadCsvCommentViewModel = new UploadCsvCommentViewModel()
                {
                    Vader = null,
                    SentiWordNet = null,
                    Hybrid = commentViewModelsHybrid
                };               
            }

            return View(nameof(Index), uploadCsvCommentViewModel);
        }
    }
}
