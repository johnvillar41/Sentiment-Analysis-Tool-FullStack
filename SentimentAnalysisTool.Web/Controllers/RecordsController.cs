using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using SentimentAnalysisTool.Data.Models;
using SentimentAnalysisTool.Services.Interfaces;
using SentimentAnalysisTool.Web.Enums;
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
            try
            {
                UploadCsvCommentViewModel uploadCsvCommentViewModel = new();
                if (algorithmnType == AlgorithmnType.Vader)
                {
                    var commentVaderObjects = await _recordsService.AddRecordAsync<VaderModel>(file, _configuration.GetValue<string>("BaseUrl"));
                    var commentVaderViewModels = commentVaderObjects.Select(m => new CommentVaderViewModel(m));
                    return PartialView("_CommentsPartialVader", commentVaderViewModels.ToList());
                }

                if (algorithmnType == AlgorithmnType.SentiWordNet)
                {
                    var commentSentiwordObjects = await _recordsService.AddRecordAsync<SentiWordNetModel>(file, _configuration.GetValue<string>("BaseUrl"));
                    var commentSentiwordViewModels = commentSentiwordObjects.Select(m => new CommentSentiWordNetViewModel(m));
                    return PartialView("_CommentsPartialSentiwordnet", commentSentiwordViewModels.ToList());
                }

                if (algorithmnType == AlgorithmnType.Hybrid)
                {
                    var commentHybridObjects = await _recordsService.AddRecordAsync<HybridModel>(file, _configuration.GetValue<string>("BaseUrl"));
                    var commentHybridViewModels = commentHybridObjects.Select(m => new CommentHybridViewModel(m));
                    return PartialView("_CommentsPartialHybrid", commentHybridViewModels.ToList());
                }
                return View(nameof(Index), uploadCsvCommentViewModel);
            }
            catch (HttpRequestException ex)
            {
                return BadRequest(ex.Message);
            }           
        }
    }
}
