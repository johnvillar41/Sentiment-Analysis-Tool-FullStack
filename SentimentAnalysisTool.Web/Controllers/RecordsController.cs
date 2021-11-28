using Microsoft.AspNetCore.Mvc;
using SentimentAnalysisTool.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SentimentAnalysisTool.Web.Controllers
{
    public class RecordsController : Controller
    {
        private readonly IRecordsService _recordsService;
        public RecordsController(IRecordsService recordsService)
        {
            _recordsService = recordsService;
        }
        public async Task<IActionResult> Index()
        {
            //await _recordsService.
            return View();
        }
    }
}
