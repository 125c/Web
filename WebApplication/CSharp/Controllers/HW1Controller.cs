using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CSharp.Controllers
{
    public class HW1Controller : Controller
    {
        public void hw1_1()
        {
            int a = 42;
            float b = 2.5f;
            double plus = a + b;
            double minus = a - b;
            double cross = a * b;
            double mod = a / b;
            double rest = a % b;

            Response.Write("a+b=" + plus + "<br>" + "a-b=" + minus + "<br>" + "a*b=" + cross +
                "<br>" + "a / b=" + mod + "<br>" + "a % b=" + rest);

        }//http://localhost:59858/hw1/one
        public double hw1_2(int cf)
        {
            return cf * 9 / 5 + 32;
        }

        public void hw1_3(int x, int y)
        {
            x += y;
            y = x - y;
            x -= y;
            Response.Write("x=" + x + "y=" + y);
        }

        public string Hw1_4(int score)
        {
            score = score / 10;
            switch (score)
            {
                case 10:
                    return "優等";
                case 9:
                    return "優等";
                case 8:
                    return "甲等";
                case 7:
                    return "乙等";
                case 6:
                    return "丙等";
            }
            return "丁等";
            //5.請利用回圈敘述寫一顯示1~Ｎ的整數中，不是5的倍數的程式，並輸出其結果，Ｎ的值須由參數傳入。
        }
        public void Hw1_5(int fi) {

            for (int i = 0; i<=fi; i++)
            {
                if (i % 5 != 0) 
                Response.Write(i + "<br>");
            }    
        }
        //6.請利用回圈敘述計算1~N的整數中，除了3倍數以外所有數的總合，並輸出其結果，Ｎ的值須由參數傳入。
        public void Hw1_6(int th)
        {
            int sum=0;
            for (int i = 0; i <= th; i++)
            {
                if (i % 3 != 0)
                    sum += i;        
            }
            Response.Write(sum);
        }
        public void Hw1_7(int n)
        {
            string a="" ;
            for (int i = 1; i <= n; i++)
            {
                a += "*";//變數不要重複，不然會被蓋過去
                Response.Write(a + "<br>");       
            }  
        }
        public void Hw1_8(int r,int y) {
            while (r <= 9)
            {
                y = 1;
                while (y <= 9)
                {
                    Response.Write(r + "*" + y + "=" + r * y);
                    Response.Write("<br>");
                    y++;
                }
                r++;
                Response.Write("<br>");
            }
            Response.Write("<hr>");
        }
    }


}