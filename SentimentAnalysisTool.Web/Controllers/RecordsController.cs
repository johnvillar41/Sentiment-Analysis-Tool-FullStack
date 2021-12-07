using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using SentimentAnalysisTool.Data.Models;
using SentimentAnalysisTool.Services.Interfaces;
using SentimentAnalysisTool.Web.Enums;
using SentimentAnalysisTool.Web.Models;
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

        public IActionResult Index(IList<CommentVaderViewModel> comments)
        {
            if (comments.Count == 0)
                comments = new List<CommentVaderViewModel>();

            return View(comments);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UploadCsvFile(
            [FromForm] IFormFile file,
            [FromForm] AlgorithmnType algorithmn)
        {
            if (algorithmn == AlgorithmnType.Vader)
            {
                var commentVaderObject = await _recordsService.AddRecordAsync<VaderModel>(file, _configuration.GetValue<string>("BaseUrl"));
                var commentViewModels = commentVaderObject.Select(m => new CommentVaderViewModel(m)).ToList();
                return View(nameof(Index), commentViewModels);
            }

            if (algorithmn == AlgorithmnType.SentiWordNet)
                return Ok(await _recordsService.AddRecordAsync<SentiWordNetModel>(file, _configuration.GetValue<string>("BaseUrl")));
            if (algorithmn == AlgorithmnType.Hybrid)
                return Ok(await _recordsService.AddRecordAsync<HybridModel>(file, _configuration.GetValue<string>("BaseUrl")));

            return BadRequest();
        }
    }
}
