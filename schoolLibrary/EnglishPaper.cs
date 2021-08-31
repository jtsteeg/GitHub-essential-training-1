using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schoolLibrary
{
    public class EnglishPaper
    {
        public string Title { get; set; }
        public int MinWordCount { get; set; }
        public string PaperText { get; set; }
        public int WordCount
        {
            get { return PaperText.WordCount(); }
        }
    }
}
