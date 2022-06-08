using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CSharp.Controllers
{
    public class _04HW3Controller : Controller
    {
        //1.弄一副牌放到陣列中2.洗牌，把陣列中的元素隨機打亂3.發牌，把陣列中的元素依序顯示

        // GET: _04HW3

        public void DealCard() 
        {
            string[] poker = new string[52];//宣告52個元素大小的陣列，所以值為0～51

            for (int i = 0; i < poker.Length; i++) 
            { 
                poker[i]=(i+1).ToString();
                Response.Write("<img src='../poker_img/" + (1+i) + ".gif' />");
            }

            //foreach (var item in poker)
            //{
            //    Response.Write("<img src='../poker_img/" + item + ".gif' />");
            //}
            Response.Write("<hr/>");
            //洗牌
            Random r = new Random();
            int temp = 0;
            string t ="";
            for (int i = 0; i < poker.Length; i++)
            {
                temp = r.Next(52);
                t = poker[i];
                poker[i] = poker[temp];
                poker[temp] = t;
               // Response.Write("<img src='../poker_img/" + poker[i]+ ".gif' />");
                
            }

            foreach (var item in poker)
            {
                Response.Write("<img src='../poker_img/" + item + ".gif' />");
            }
           // Response.Write("<hr>");

            //for (int a = 1; a < 4; a++)
            //{
            //    Response.Write("<img src='../poker_img/" + a + ".gif' />");  
            //}
            Response.Write("<hr/>");
                string p1 = "", p2 = "", p3 = "", p4 = "", result = "";
                for(var i=0; i<poker.Length; i++)
                {
                    result = "<img src='../poker_img/" + poker[i] + ".gif' />";

                    switch (i % 4)
                    {
                        case 0:
                            p1 += result;
                            break;
                        case 1:
                            p2 += result;
                            break;
                        case 2:
                            p3 += result;
                            break;
                        case 3:
                            p4 += result;
                            break;
                    }
                }

                Response.Write("咖波:" + p1 + "<br />");
                Response.Write("松尼:" + p2 + "<br />");
                Response.Write("兔兔:" + p3 + "<br />");
                Response.Write("亞拉:" + p4 + "<br />");
        }

        //public int ran()
        //{
        //    int number = 0;
        //    Random r = new Random();
        //    //Random類別(物件的設計圖：食材食譜) r物件（菜） Random();建構子/建構函數/函式（煮菜的方法）
        //    //鑄造物件 ooo xxx=new ooo();
        //    //number = r.Next();//0-2^32
        //    //number = r.Next(100);//0-99
        //    //number = r.Next(100,500);//100-500
        //    number = r.Next(53);

        //    int[] array = new int[52];
        //    for (int i = 0; i < 5; i++) {
        //        array[i] = r.Next();
        //    Response.Write(number+",");
        //    }
        //    return number;
        //}
    }
}