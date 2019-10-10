using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;


namespace WordCount
{
    class WriteFile
    {
        /// <summary>
        /// 将一个字符串写入指定路径的文件中
        /// </summary>
        /// <param name="path">指定路径的文件</param>
        /// <param name="str">要写入文件的字符串</param>
        public void fileWrite(string path, string str)
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
