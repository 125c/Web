using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CSharp.Controllers
{
    public class _03HW2Controller : Controller
    {
        // GET: _03HW2
        //1.	質數判斷(必須用回圈，不得使用陣列)
        //請宣告一個整數變數，值由參數傳入，並判斷其是否為質數，若是，請在螢幕顯示「○○是質數」，
        //若不是，請在螢幕顯示「○○不是質數」。
        public string No1(int n)
        {
            //用for迴圈去檢查/1/2/3/4…有餘數為0是質數
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    return n + "不是質數";
                    //Response.Write(n + "");
                }
            }
            return n + "是質數";
            //http://localhost:59858/_03HW2/No1?n=17
            //int i = 2;
            //while (n % 1 == 0)
            //{
            //    return n + "不是質數";   
            //    i++;
            //}
            //return n + "是質數";
        }
        public void No2(int a, int b) //輾轉相除法，除到餘數為0商是最大公因數，不用先判斷大小。停止條件
         //if(m%n==0) 
        {
            int A = a, B = b;
            int z = 0;
            while (A % B != 0)
            { 
                z = A % B;
                A = B;
                B = z; 
            }          
            Response.Write(a+"與"+b+ "之最大公因數為"+B);
        }
        public string No2_1(int n, int m) //輾轉相除法，除到餘數為0商是最大公因數，不用先判斷大小。停止條件
                                      //if(m%n==0) 
        {
            int M = m, N = n;
            int z=0;
            while (M % N!=0){
                z = M % N;
                M = N;
                N = z;

            }
            return m + "與" + n + "最大公因數為" + N;
        }
        //1234%10=4
        //1234/10=123
        //123%10=3
        //123/10=12
        //轉回4*10+3 (43+2)*10+1
        public string No3(int n)
        {
            int N = n, result = 0;
            int q = 0, r = 0;
            do
            {
                r = N % 10;
                q = N / 10;
                N = q;
                result *= 10;
                result += r;
            } while (q != 0);
            if (n == result)
                return n + "是迴文";
            return n + "不是迴文";
        }

    }
}