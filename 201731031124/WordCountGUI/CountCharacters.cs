using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCountGUI
{
    class CountCharacters
    {
        /// <summary>
        /// 统计字符串中所有单词总数
        /// </summary>
        /// <param name="text">要统计的字符串</param>
        /// <returns>返回一个储存了所有单词的集合包括重复的单词</returns>
        public int wordsNum(List<string> wordString)
        {
            return wordString.Count();
        }
    }
}
