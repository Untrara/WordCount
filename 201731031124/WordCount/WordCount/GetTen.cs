using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WordCount
{
    public class GetTen
    {
        /// <summary>
        /// 计算频率最高的单词
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public Dictionary<string, int> getWordNum(List<string> wordString)
        {
            Dictionary<string, int> wordNum = new Dictionary<string, int>();
           
            foreach (string str in wordString)
            {
                              
                if (wordNum.ContainsKey(str))
                {
                    wordNum[str]++;
                }
                else
                {
                    wordNum[str] = 1;

                }
            }
            return wordNum.OrderByDescending(r => r.Value).ToDictionary(r => r.Key, r => r.Value);
        }
    }
}
