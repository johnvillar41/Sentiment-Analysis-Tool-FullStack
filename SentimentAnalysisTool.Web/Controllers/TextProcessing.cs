using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using SentimentAnalysisTool.Services.Interfaces;
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
        private readonly IConfiguration _configuration;
        private readonly HttpClient _httpClient;
        public TextProcessing(
            ISlangRecordsService slangRecordsService, 
            HttpClient httpClient, 
            IConfiguration configuration)
        {
            _slangRecordsService = slangRecordsService;
            _httpClient = httpClient;
            _configuration = configuration;
        }
        public async Task<IActionResult> Index(int? corpusTypeId)
        {
            var slangs = await _slangRecordsService.FetchAllSlangRecordAsync(corpusTypeId, _configuration.GetValue<string>("BaseUrl"));
            return View(slangs);
        }
    }
}
