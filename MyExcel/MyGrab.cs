using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Leung.Tools
{
    public static  class MyGrab
    {
        public static string[] GetContent(string url)
     {
         //第一句，抓
         XElement xml = XElement.Load(url);

         //第二句，取
         //string txt = "------------ 数学大冒险 -------------" + "_";
         var list = xml.Element("channel").Elements("item")
                       //.Select((m, index1) => txt += index1.ToString() + ":" + m.Element("title").Value + "_")
                       .Select((m, index1) => index1.ToString() + ":" + m.Element("title").Value + "_")

                       //.Where((n, index2) => index2 < 5)
                        //.ToList();
                       .ToArray();   //输出为数组
        

         return list;
     }


    }
}
