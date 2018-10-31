using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WordCountApp
{
    public partial class WordCount : System.Web.UI.Page
    {
         const string inputPath = @"C:\temp\wordlist.txt";
         const string ouputPath = @"C:\temp\results.txt";
        protected void Page_Load(object sender, EventArgs e)
        {
            var wordCounters = new IWordCounter[]{ };
            WordCounter wcr = new WordCounter();
          
            foreach (var wc in wordCounters)
            {
                GC.Collect();
                GC.WaitForPendingFinalizers();               
                var wcResult = wcr.CountWords(inputPath);
                using (StreamWriter writer = new StreamWriter(ouputPath))
                {
                    writer.WriteLine(wcResult.GetType().Name + "   " + Convert.ToString(wcResult.Count) + Environment.NewLine);
                }
              
             
            }

         
        }
    }
}