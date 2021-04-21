using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Windows;
using followHTTPsysDiag = System.Diagnostics;// using alias 
//利用C#隱藏Console Window命令模式視窗 http://bit.ly/2tZWfzj
namespace docs_microsoft_page_ConsoleApp//把線上技術手冊網址中英互換
{
    class Program
    {
        [STAThread]//http://bit.ly/2v8oaxg
        static void Main(string[] args)
        {
            String add = String.Empty;
            add=Clipboard.GetText();//先複製原網址到剪貼簿以供讀取
            if(add.IndexOf("http")==-1) return;
            if (add.IndexOf("http") > 0) return;
            if (add.IndexOf("microsoft") == -1) return;
            //if (add.IndexOf("https://docs.microsoft.com/") == -1) return;//http://bit.ly/2upzXtn
            if (add.IndexOf("zh-tw") > 0) add=add.Replace("zh-tw", "en-us");
            else if (add.IndexOf("en-us") > 0) add=add.Replace("en-us", "zh-tw");
            //followHTTPsysDiag::Process.Start(add);//http://bit.ly/2vsxZp4 另可參：http://bit.ly/2tZkcZg http://bit.ly/2vsii1d
            C_sharp_MSEdge_Chromium_Browser_automating.BrowserChrome.OpenLinkChrome(add);
            /*
            using System;
            using System.Windows.Forms;
 
            namespace WindowsFormsApplication1
            {
                public partial class Form1 : Form
                {
                    public Form1()
                    {
                        InitializeComponent();
                    }
 
                    private void button1_Click(object sender, EventArgs e)
                    {
                        //使用預設瀏覽器
                        System.Diagnostics.Process.Start( "http://google.com.tw");
 
                        //使用IE瀏覽器
                        System.Diagnostics.Process.Start("iexplore.exe", "http://google.com.tw");
 
                        //使用Chrome瀏覽器
                        System.Diagnostics.Process.Start("chrome.exe", "http://google.com.tw");
 
                        //使用Firefox瀏覽器
                        System.Diagnostics.Process.Start("firefox.exe", "http://google.com.tw");
 
                        //使用Safari瀏覽器
                        System.Diagnostics.Process.Start("safari.exe", "http://google.com.tw");
                    }
                }
            }
            */
        }
    }
}
