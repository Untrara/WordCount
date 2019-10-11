using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WordCountGUI
{
    class CountWords
    {
        
            /// <summary>
            /// 统计字符串中所有字符总数
            /// </summary>
            /// <param name="text">要统计字符数的字符串</param>
            /// <returns>字符总个数</returns>
            public int charactersNum(string text)
            {
                int ch = 0;
                //\S——匹配任何非空白字符（除了空格、换行、制表符等的任何字符）
                //|——匹配二选一
                ch = Regex.Matches(text, @"[\S| ]").Count;
                return ch;
            }
        
    }
}
