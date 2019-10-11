using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordCountGUI
{
    public partial class Form1 : Form
    {
        int n, m = 0;
        String inputtxt = null;
        String order = null;
        String text = null;
        String str = null;
        String outputPath = null;
        CountWords cw = new CountWords();
        CountCharacters cc = new CountCharacters();
        GetTen gt = new GetTen();
        WordString ws = new WordString();
        CiZu cz = new CiZu();
        WriteFile wf = new WriteFile();
        LineNum ln = new LineNum();
        public Form1()
        {
            InitializeComponent();
           
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        public void InputBtn_Click(object sender, EventArgs e)
        {
            if (inputBox.TextLength != 0)
            {
                inputtxt = inputBox.Text.ToString();
                MessageBox.Show("字符已提交！！请在下面输入要执行的命令！！");
                
            }
            else
            {
                MessageBox.Show("输入为空，请重新输入");
            }
            
        }

        public void OrderBtn_Click(object sender, EventArgs e)
        {
            Boolean flag = true;
            if (orderBox.TextLength != 0 && inputBox.TextLength != 0)
            {
                string[] arrMessSplit = orderBox.Text.ToString().Split(' ');
                for (int i = 0; i < arrMessSplit.Length; i++)
                {                   
                    if (string.Equals(arrMessSplit[i], "-m"))
                    {
                        flag = false;
                        m = int.Parse(arrMessSplit[i + 1]);
                    }
                    if (string.Equals(arrMessSplit[i], "-n"))
                    {
                        flag = false;
                        n = int.Parse(arrMessSplit[i + 1]);
                    }
                    if (string.Equals(arrMessSplit[i], "-o"))
                        outputPath = arrMessSplit[i + 1];
                }
                if (flag == false)
                {
                    string text = inputtxt.ToLower();                    //读取文本内容并全部转成小写字母       
                    int ch = cw.charactersNum(text);                                           //所有字符总数
                    List<string> wordListX = ws.wordString(text);                           //得到符合规则的，去掉空格等字符的字符串列表
                    int word = cc.wordsNum(wordListX);                                           //所有单词总数
                    int nr = ln.linesNum(text);                                                //行数    
                    Dictionary<string, int> wordNum = gt.getWordNum(wordListX);              //统计文件中各单词出现次数
                    string wordList2 = cz.numOfCiZu(wordListX, m);

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
                    outputBox.Text = str;
                }
                else {
                    MessageBox.Show("指令有误，重新输入");
                }
               
            }
            else {
                MessageBox.Show("不要乱来，有个地方输入为空啦");
            }      
        }

        public void TextBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void InputBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LeadOutBtn_Click(object sender, EventArgs e)
        {
            str = outputBox.Text;
            wf.fileWrite("F:\\QQPCmgr\\Desktop\\"+outputPath, str);
            MessageBox.Show("已成功导出");
        }
    }
}
