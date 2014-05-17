using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinguaTest
{
    class Utils
    {
        public static string FormalWord(string w)
        {
            w = w.ToLower();
            return w[0].ToString().ToUpper() + w.Substring(1, w.Length - 1);
        }
    }
}
