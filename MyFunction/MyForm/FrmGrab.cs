using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;
using Leung.Tools;
using Leung.MyExcelExt;
using System.Diagnostics;
using System.IO;
using System.Reflection;


namespace MyFunction.MyForm
{
    public partial class FrmGrab : Form
    {
        public FrmGrab()
        {
            InitializeComponent();
            
        }

        private string url = @"http://www.matrix67.com/blog/feed";
        

        private void btnGetText_Click(object sender, EventArgs e)
        {
           
            Excel.Range rng = Globals.ThisAddIn.Application.Range["a1"];
            if (url != null)
            {
               string[] str= MyGrab.GetContent(url); //提取网抓内容
               //string[] strArr =str.Split('_');//分割成数组
               rng.ExportDataInSht<string>(str);//输出到Excel单元格
               rng.EntireColumn.AutoFit();//自动调整列宽
                
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            url = textBox1.Text;
        }


        private void btnGetXmlPath_Click(object sender, EventArgs e)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;//获取基目录，它由程序集冲突解决程序用来探测程序集。
            url = path + @"\XMLFile.xml";
            textBox1.Text=url;
            MessageBox.Show("加载完毕！");
        }
    }
}
