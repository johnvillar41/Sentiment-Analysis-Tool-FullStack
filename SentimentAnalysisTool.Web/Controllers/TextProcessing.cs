﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SentimentAnalysisTool.Web.Controllers
{
    public class TextProcessing : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
