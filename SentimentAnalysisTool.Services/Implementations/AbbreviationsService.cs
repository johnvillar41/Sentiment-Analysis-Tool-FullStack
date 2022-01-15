using SentimentAnalysisTool.Data.Models;
using SentimentAnalysisTool.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SentimentAnalysisTool.Services.Implementations
{
    public class AbbreviationsService : IAbbreviationsService
    {
        public Task<IEnumerable<AbbreviationModel>> FetchAbbreviationsAsync(int? corpusTypeId, string baseUrl)
        {
            throw new NotImplementedException();
        }
    }
}
