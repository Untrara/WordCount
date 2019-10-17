using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WordCountGUI
{
    class LineNum
    {
        /// <summary>
        /// 统计字符串中文本行数
        /// </summary>
        /// <param name="text">要统计的字符串</param>
        /// <returns>字符串行数</returns>
        public int linesNum(string text)
        {
            int lines = 0;
            //\r——匹配硬回车符
            lines = Regex.Matches(text, @"\r").Count + 1;
            return lines;
        }
    }
}
