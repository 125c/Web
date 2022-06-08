using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CSharp.Controllers //_02Statemment
{
    public class _02StatemmentController : Controller
    {
        public void statement()
        {
            int a = 10;
            a = 20;
            a += 10;
            a -= 5;//a:25
            a *= 10;//a:250
            a /= 25;//a:10
            a = a + 1;
            a += 1;
            a++;//a:13
            Response.Write(a);
            Response.Write("<hr>");

            int x = 123;
            float y = 12.1234567f;
            float z = 12.134f;
            float result = 0;

            result = x + z;
            Response.Write("y=" + y);
            Response.Write("<br>");
            Response.Write("x+z=" + result);
            Response.Write("<hr>");

            float xx = 10000.9f;
            float yy = 9999.3f;
            Response.Write("xx=" + xx);
            Response.Write("<br>");
            Response.Write("yy=" + yy);
            Response.Write("xx-yy=" + (xx - yy));
            Response.Write("<hr>");

            decimal t = (decimal)123.123;
            Response.Write("xx+yy=" + ((decimal)xx - (decimal)yy));
            Response.Write("<hr>");
        }//http://localhost:59858/_02Statemment/statement

        //if敘述句
        public string IfStatement(int age)
        {
            //0-6歲免票, 7-20歲半票, 20歲以上全票

            if (age > 20)
            {
                return "全票";
            }
            else if (age > 6)
                return "半票";
            else if (age >= 0)
                return "免票";
            return "年齡輸入錯誤";
        }//http://localhost:59858/_02Statemment/IfStatement?age=12 半票
        //http://localhost:59858/_02Statemment/IfStatement?age=aaa 錯誤

        //switch敘述句
        public string SwitchStatement(string color)
        {
            switch (color)
            {
                case "y":
                    return "黃色";
                case "g":
                    return "綠色";
                case "r":
                    return "紅色";
            }
            return "這不是黃綠紅";
        }//http://localhost:59858/_02Statemment/SwitchStatement?color=y 黃色
        //for敘述句
        public string ForStatement()
        {
            string[] arrRainbow = { "紅", "橙", "黃", "綠", "藍", "靛", "紫" }; //陣列

            string[] arrColor = { "red", "orange", "yellow", "green", "blue", "indigo", "violet" };

            string result = "";

            for (int i = 0; i < arrRainbow.Length; i++)
            {
                result += "<h2 style='color:" + arrColor[i] + "'>" + arrRainbow[i] + "</h2>";
            }
            return result;
        }
        //foreach
        public void foreachStatement()
        {
            string[] arrRainbow = { "紅", "橙", "黃", "綠", "藍", "靛", "紫" }; //陣列

            foreach (string item in arrRainbow)
            {
                Response.Write(item);
            }
        }
        //While
        public void WhileStatement()
        {
            int i = 1;
            while (i <= 52)
            {
                Response.Write("<img src='../poker_img/" + i + ".gif' />");
                i++;
            }
        }
        public void DoWhileStatement()
        {
            int i = 1;
            do
            {
                Response.Write("<img src='../poker_img/" + i + ".gif' />");
                i++;
            } while (i <= 52);
        }
    }
}
//算數運算與指定運算
//1.算數運算子 +,-,*,/,%
//2.（）小括號
//3.連接符號 +
//4.負號 -
//5.優先權
//  ()
//  * , / , %
//  + , -
//6.留意浮點數運算後遺失精準度的問題

//選擇判斷式
//1.if
//2.switch

//迴圈
//1.for
//2.foreach
//3.while
//4.do....while