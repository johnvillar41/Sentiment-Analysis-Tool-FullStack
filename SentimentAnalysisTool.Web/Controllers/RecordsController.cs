using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using SentimentAnalysisTool.Services.Interfaces;
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
        public async Task<IActionResult> UploadCsvFile(IFormFile file)
        {
            
            var result = await _recordsService.AddRecordAsync(file, _configuration.GetValue<string>("BaseUrl"));
            if (result)
                return RedirectToAction(nameof(Index)); //TODO ADD Return for RecordViewModel after uploading file

            return BadRequest();
        }
    }
}
