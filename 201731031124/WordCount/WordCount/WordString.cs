using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace WordCount
{
    class WordString
    {
        public  List<string> wordString(string text)
        {
            List<String> temp = new List<string>();
            MatchCollection matches = Regex.Matches(text, @"[A-Za-z]{4}[A-Za-z0-9]*(\W|$)");
            foreach (Match match in matches)//删除单词后的句点，逗号，空格
            {
                string str = match.ToString();
                str = str.Replace(",", "");
                str = str.Replace(" ", "");
                str = str.Replace(".", "");
                temp.Add(str);
            }
            return temp;
        }
    }
}
