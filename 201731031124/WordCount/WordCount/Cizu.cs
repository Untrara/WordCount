using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WordCount
{
    public class Cizu
    {
        public string numOfCiZu(List<string>wordString, int m)
        {
            
            List<String> ans = new List<string>();
            Dictionary<string, int> letter = new Dictionary<string, int>();
            string ret = null;
            int len = wordString.Count();
            for (int i = 0; i <= len - m; i++)
            {
                string tem = null;
                for (int j = i; j < i + m; j++)
                {
                    //if (j >= len-m)
                    //    break;
                    tem += wordString[j] + " ";
                }
                if (tem != null)
                    ans.Add(tem);
            }
            foreach (string str in ans)
            {
                if (letter.ContainsKey(str))
                {
                    letter[str]++;
                }
                else
                {
                    letter[str] = 1;
                }
            }
            foreach (KeyValuePair<string, int> kvp in letter)
            {
                ret += kvp.Key + ": " + kvp.Value.ToString() + "\r\n";
            }


            return ret;
        }
    }
}
