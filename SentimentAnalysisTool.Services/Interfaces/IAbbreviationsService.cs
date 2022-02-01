using Microsoft.AspNetCore.Http;
using SentimentAnalysisTool.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SentimentAnalysisTool.Services.Interfaces
{
    public interface IAbbreviationsService
    {
        Task<IEnumerable<AbbreviationModel>> FetchAbbreviationsAsync(int? corpusTypeId, string baseUrl);
        Task<bool> DeleteAbbreviationAsync(int? abbreviationId, string baseUrl);
        Task<bool> AddAbbreviationsAsync(IFormFile file, int corpusTypeId, string baseUrl);
    }
}
