using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;



namespace WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputPath = null;
            try
            {
                if (args != null && args.Length > 0)
                {
                    inputPath = args[0].ToString();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            string outputPath = "output.txt";


            string text = File.ReadAllText(inputPath).ToLower();                    //读取文本内容并全部转成小写字母
            int ch = charactersNum(text);                                           //所有字符总数
            List<string> wordList = wordsNum(text);                                 //字符串中所有单词集合（包括重复的单词）
            int word = wordList.Count;                                              //所有单词总数
            int nr = linesNum(text);                                                //行数

            //统计文件中各单词出现次数
            Dictionary<string, int> wordNum = getWordNum(text);

            //构造要输出的信息字符串
            string str = String.Format("characters:{0}\r\nwords:{1}\r\nlines:{2}\r\n", ch, word, nr);
            StringBuilder sb = new StringBuilder();





            //将单词个数输出
            int size = 0;
            string wordNumOut = null;
            foreach (KeyValuePair<string, int> kvp in wordNum)
            {
                size++;
                if (size > 10)
                    break;
                wordNumOut += "<" + kvp.Key + ">" + ": " + kvp.Value.ToString();
                wordNumOut += "\r\n";

            }
            //将字符串信息写入指定路径的文件
            str = str + wordNumOut;
            fileWrite(outputPath, str);

        }

        //
        public static Dictionary<string, int> getWordNum(string text)
        {
            Dictionary<string, int> wordNum = new Dictionary<string, int>();
            MatchCollection temps = Regex.Matches(text, @"[A-Za-z]{4}[A-Za-z0-9]*(\W|$)");
            foreach (Match match in temps)
            {
                string str = match.ToString();
                str = str.Replace(",", "");
                str = str.Replace(" ", "");
                str = str.Replace(".", "");                   //将跟在单词后的空格逗号，句点删除
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





        /// <summary>
        /// 统计字符串中所有字符总数
        /// </summary>
        /// <param name="text">要统计字符数的字符串</param>
        /// <returns>字符总个数</returns>
        public static int charactersNum(string text)
        {
            int ch = 0;
            //\S——匹配任何非空白字符（除了空格、换行、制表符等的任何字符）
            //|——匹配二选一
            ch = Regex.Matches(text, @"[\S| ]").Count;
            return ch;
        }

        /// <summary>
        /// 统计字符串中所有单词总数
        /// </summary>
        /// <param name="text">要统计的字符串</param>
        /// <returns>返回一个储存了所有单词的集合包括重复的单词</returns>
        public static List<string> wordsNum(string text)
        {
            List<string> words = new List<string>();
            //\W——匹配任何非单词字符（除了字母和数字以外的任何字符）
            MatchCollection matches = Regex.Matches(text, @"[A-Za-z]{4}[A-Za-z0-9]*(\W|$)");
            foreach (Match match in matches)
            {
                words.Add(match.Value);
            }
            return words;
        }

        /// <summary>
        /// 统计字符串中文本行数
        /// </summary>
        /// <param name="text">要统计的字符串</param>
        /// <returns>字符串行数</returns>
        public static int linesNum(string text)
        {
            int lines = 0;
            //\r——匹配硬回车符
            lines = Regex.Matches(text, @"\r").Count + 1;
            return lines;
        }


        /// <summary>
        /// 将一个字符串写入指定路径的文件中
        /// </summary>
        /// <param name="path">指定路径的文件</param>
        /// <param name="str">要写入文件的字符串</param>
        public static void fileWrite(string path, string str)
        {
            FileStream fs = new FileStream(path, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            sw.Write(str);
            //写入信息完毕
            sw.Close();
            fs.Close();
        }

    }
}
