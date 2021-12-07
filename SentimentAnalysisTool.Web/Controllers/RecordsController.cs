using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using SentimentAnalysisTool.Data.Models;
using SentimentAnalysisTool.Services.Interfaces;
using SentimentAnalysisTool.Web.Enums;
using SentimentAnalysisTool.Web.Models;
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

        public IActionResult Index(RecordViewModel record)
        {
            if(record == null)
                return View();

            return View(record);
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
                return Ok(commentVaderObject);
            }
            
            if(algorithmn == AlgorithmnType.SentiWordNet)
                return Ok(await _recordsService.AddRecordAsync<SentiWordNetModel>(file, _configuration.GetValue<string>("BaseUrl")));
            if (algorithmn == AlgorithmnType.Hybrid)
                return Ok(await _recordsService.AddRecordAsync<HybridModel>(file, _configuration.GetValue<string>("BaseUrl")));
            
            return BadRequest();
        }
    }
}
