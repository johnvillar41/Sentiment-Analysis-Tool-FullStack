using System.Collections.Generic;

namespace SentimentAnalysisTool.Web.Models
{
    public class CorpusRecordViewModel
    {
        public int CorpusRecordId { get; set; }        
        public IEnumerable<CorpusTypeViewModel> CorpusTypeViewModels { get; set; }
    }
}