using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Excel= Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;	
		 
	

namespace Leung.MyExcelExt
{
    public static class MySheetExt
    {
        /// <summary>
        /// 判断是否存在指定的工作表，扩展方法
        /// </summary>
        /// <param name="book"></param>
        /// <param name="shtName"></param>
        /// <returns></returns>
        public  static bool IsWorkSheet(this Excel.Workbook book,string shtName)
        {
            if (shtName==null)
            {
                throw new ArgumentNullException("工作表名不能为空！");
            }

            bool bRet = false;
            foreach (Excel.Worksheet wkSht in book.Worksheets)
            {
                if (wkSht.Name == shtName)
                {
                    bRet = true;
                    return bRet;
                }
            }
            return bRet;

        }

    }


    public static class MyAppExt 
    {
        /// <summary>
        /// 判断是否存在指定的工作簿，并且激活
        /// </summary>
        /// <param name="app"></param>
        /// <param name="wkbName"></param>
        /// <returns></returns>
        public static bool IsWorkBook(this Excel.Application app, string wkbName)
        {
            if (wkbName == null)
            {
                throw new ArgumentNullException("工作表名不能为空！");
            }
            bool bRet = false;
            foreach (Excel.Workbook wkBk in app.Workbooks)
            {
                if (wkBk.Name == wkbName)
                {
                    bRet = true;
                    return bRet;
                }
            }
            return bRet;


        }
    }

    public  static class MyRangeExt
    {
       
        /// <summary>
        /// 一维数组直接导出到工作表指定单元格里，泛型+扩展方法
        /// </summary>
        /// <typeparam name="T">类型</typeparam>
        /// <param name="wkRng">单元格</param>
        /// <param name="arrayData">一维数组</param>
        public static void ExportDataInSht<T>(this  Excel.Range wkRng, T[] arrayData)
        {
            wkRng.get_Resize(arrayData.GetLength(0), 1).Value = wkRng.Application.WorksheetFunction.Transpose(arrayData);

        }


    }
}
