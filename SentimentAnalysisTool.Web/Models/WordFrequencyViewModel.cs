using SentimentAnalysisTool.Data.Models;

namespace SentimentAnalysisTool.Web.Models
{
    public class WordFrequencyViewModel
    {
        public int WordFrequencyId { get; set; }        
        public string Word { get; set; }
        public int WordFrequency { get; set; }
        public WordFrequencyViewModel(WordFrequencyModel wordFrequency)
        {
            WordFrequencyId = wordFrequency.WordFrequencyId;
            Word = wordFrequency.Word;
            WordFrequency = wordFrequency.WordFrequency;
        }
        public WordFrequencyViewModel()
        {

        }
    }
}