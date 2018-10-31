﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCountApp
{
    interface IWordCounter
    {
      IDictionary<string, int> CountWords(string path);
       
    }
}
