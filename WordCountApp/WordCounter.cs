using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Text;

namespace WordCountApp
{
    public class WordCounter: IWordCounter
    {
        private static readonly char[] separators = { ' ' };
        
        public IDictionary<string, int> CountWords(string path)
        {
            var wordCount = new Dictionary<string, int>();

            foreach (var line in File.ReadLines(path, Encoding.UTF8))
            {
                var words = line.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                foreach (var word in words)
                {
                    int count;
                    wordCount.TryGetValue(word, out count);
                    wordCount[word] = count + 1;
                }
            }

            return wordCount;
        }
   

    }
}