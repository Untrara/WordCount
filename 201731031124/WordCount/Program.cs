using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;



namespace WordCount
{
    public class Program
    {
        static void Main(string[] args)
        {
            string inputPath = null;
            string outputPath = "output.txt";
            
            int m = 0;                              //词组单词个数
            int n = 0;                             //需要统计最高频率输出的单词个数
            if (args.Length == 4)
            {
                inputPath = args[1];
                outputPath = args[3];
            }
            else
            {
                for (int i = 0; i < args.Length; i++)
                {
                    if (string.Equals(args[i], "-i"))
                        inputPath = args[i + 1];
                    if (string.Equals(args[i], "-o"))
                        outputPath = args[i + 1];
                    if (string.Equals(args[i], "-m"))
                        m = int.Parse(args[i + 1]);
                    if (string.Equals(args[i], "-n"))
                        n = int.Parse(args[i + 1]);
                }
            }
           

            string text = File.ReadAllText(inputPath).ToLower();                    //读取文本内容并全部转成小写字母
            CountWord cw = new CountWord();
            CountCharacters cc = new CountCharacters();
            GetTen gt = new GetTen();
            int ch = cw.charactersNum(text);                                           //所有字符总数

            
            WordString ws = new WordString();
            List<string> wordListX = ws.wordString(text);                           //得到符合规则的，去掉空格等字符的字符串列表

            int word = cc.wordsNum(wordListX);                                           //所有单词总数
            int nr = linesNum(text);                                                //行数           


            Dictionary<string, int> wordNum = gt.getWordNum(wordListX);              //统计文件中各单词出现次数
          

            Cizu cz = new Cizu();
            
            string wordList2 = cz.numOfCiZu(wordListX, m);


            //构造要输出的信息字符串
            string str = String.Format("characters:{0}\r\nwords:{1}\r\nlines:{2}\r\n", ch, word, nr);
            


            //将需要的出现频率高的单词及出现次数放入字符串中
            int size = 0;
            string wordNumOut = null;
            foreach (KeyValuePair<string, int> kvp in wordNum)
            {
                size++;
                if (size > n)
                    break;
                wordNumOut += "<" + kvp.Key + ">" + ": " + kvp.Value.ToString();
                wordNumOut += "\r\n";

            }
            //将字符串信息写入指定路径的文件         
            str = str + wordNumOut + wordList2;
            //写入文件
            WriteFile wf = new WriteFile();
            wf.fileWrite(outputPath, str);          

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


       
    }
}
