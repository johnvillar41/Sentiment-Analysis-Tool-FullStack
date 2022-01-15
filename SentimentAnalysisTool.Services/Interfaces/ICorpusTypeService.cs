using SentimentAnalysisTool.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SentimentAnalysisTool.Services.Interfaces
{
    public interface ICorpusTypeService
    {
        Task<bool> AddCorpusTypeAsync(CorpusTypeModel corpusType, string baseUrl);
    }
}
