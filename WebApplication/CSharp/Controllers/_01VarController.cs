using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CSharp.Controllers
{
    public class _01VarController : Controller
    {
        public string MyFirstCS() // 因為回傳的資料型態是str
        {
            string w = "qwewer";
            return w;   
        }
        public int MyFirstCS1() 
        {
            int w = 56452;
            return w;
            //http://localhost:59858/_01Var/MyFirstCS1

        }
        public string checkGender( bool gender)
        {
            bool w = gender;
            if (w)
                return "M";
            return "F";
            //http://localhost:59858/_01Var/checkGender?gender=false
        }

        public string checkGender1(string name,  bool gender) 
        {
            bool w = gender;
            string n = name;
            string r = "";
            r = w ? "M" : "F";
            return "<h1>"+n+"你好 你的性別是"+r+"</h1>";
            //http://localhost:59858/_01Var/checkGender1?gender=false&name=asdqwer
        }
        public void number() //void沒有回傳函數
        {
            //數值Data Type
            byte a= 123; //8位元正整數(0~255)
            sbyte b= 123;  //8位元整數(-128~127)

            short c= 123;  //16位元整數(-32768~32767)
            int d= 123;   //32位元整數(-2147483648~2147483647)
            long e= 123; //64位元整數

            ushort f= 123;  //16位元正整數(0~65535)
            uint g= 123;   //32位元正整數
            ulong h= 123; //64位元正整數


            ///////////////////////////////////////
            float i = 123.456f;  //單精準度浮點數，比較不準，後面要+f
            double j = 123.456456456;  //倍精準度浮點數，double不用加
        }
        public string googleMap(string place)
        {
            return "<a href='https://www.google.com.tw/maps/search/" + place + "' target='_blank'>點我看地圖</a>";
        }//http://localhost:59858/_01Var/googleMap?place=%E5%87%B9%E5%AD%90%E5%BA%95%E5%85%AC%E5%9C%92

    }
}