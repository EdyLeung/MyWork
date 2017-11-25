using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;

using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;
using Leung.MyExcelExt;

namespace MyFunction
{
    public partial class Ribbon1
    {
        private string sheetName;//声明字段
        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, RibbonControlEventArgs e)
        {
           
            Excel.Workbook wkBK = Globals.ThisAddIn.Application.ActiveWorkbook;


            if (wkBK.IsWorkSheet(sheetName) != true)
            {
                System.Windows.Forms.MessageBox.Show("搜索的工作表不存在！","温馨提示"); 
            }
            else
            {
                wkBK.Worksheets[sheetName].Activate();
                System.Windows.Forms.MessageBox.Show("已定位到指定的工作表中！", "恭喜你"); 
            }
        }

        private void editBoxText_TextChanged(object sender, RibbonControlEventArgs e)
        {
            sheetName = editBoxText.Text;//赋值给字段
        }

        private void btnSearchWkb_Click(object sender, RibbonControlEventArgs e)
        {
            Excel.Application app = Globals.ThisAddIn.Application;


            if (app.IsWorkBook(sheetName) != true)
            {
                System.Windows.Forms.MessageBox.Show("搜索的工作薄不存在！", "温馨提示");
            }
            else
            {
                app.Workbooks[sheetName].Activate();
                System.Windows.Forms.MessageBox.Show("已激活指定的工作簿", "恭喜你");
            }
        }

        private void btnOpenForm_Click(object sender, RibbonControlEventArgs e)
        {
            MyForm.FrmGrab frmGrab = new MyForm.FrmGrab();
            frmGrab.Show();
        }
    }
}
