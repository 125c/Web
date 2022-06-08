using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _03Model.Models;

namespace _03Model.Controllers
{
    public class HomeController : Controller
    {
        //04-1-3 建立一般方法ShowAryDesc()-整數陣列遞減排序
        public string ShowAryDesc()
        {
            int[] score = { 78, 90, 20, 100, 66 };

            string show = "";

            //Linq查詢運算式寫法
            //var result = from s in score
            //             orderby s descending
            //             select s;

            //Linq擴充方法的寫法
            var result = score.OrderByDescending(s => s);

            //SQL
            //select s from score order by s desc

            foreach (var item in result)
            {
                show += item+", ";   
            }

            return show;


        }

        //04-1-5 建立一般方法ShowAryAsc()-整數陣列遞增排序
        public string ShowAryAsc()
        {
            int[] score = { 78, 90, 20, 100, 66 };

            string show = "";

            //Linq查詢運算式寫法
            //var result = from s in score
            //             orderby s ascending
            //             select s;

            //Linq擴充方法的寫法
            var result = score.OrderBy(s => s);

            //SQL
            //select s from score order by s

            foreach (var item in result)
            {
                show += item + ", ";
            }
            show += "<hr>";
            show += "成績平均" + result.Average();
            show += "<hr>";
            show += "成績總和" + result.Sum();

            return show;


        }

        public string LoginMember(string uid, string pwd)
        {
            //Member member = new Member();
            //member.UId = "tom";
            //member.Pwd = "123";
            //member.Name = "湯姆";

            //Member member2 = new Member();
            //member2.UId = "jsper";
            //member2.Pwd = "456";
            //member2.Name = "賈斯伯";

            //Member member3 = new Member();
            //member3.UId = "mary";
            //member3.Pwd = "789";
            //member3.Name = "瑪麗";

            Member[] members = new Member[]
            {
                new Member{ UId="tom",Pwd="123",Name="湯姆"},
                new Member{ UId="jsper",Pwd="456",Name="賈斯伯"},
                new Member{ UId="mary",Pwd="789",Name="瑪麗"}
            };

            //SQL
            //select * from members where UId='tom' and Pwd='123'



            //Linq查詢運算式寫法
            //var result = (from m in members
            //              where m.UId == uid && m.Pwd == pwd
            //              select m).FirstOrDefault();

            //Linq擴充方法的寫法
            var result = members.Where(m => m.UId == uid && m.Pwd == pwd).FirstOrDefault();

            string show = "";
            if (result != null)
            {
                show = "歡迎" + result.Name + "進入本系統";

            }
            else
                show = "帳號或密碼錯誤!";

            return show;
        }


    }
}

//04-1 Linq練習
//04-1-1 在Controllers資料夾上按右鍵,加入,控制器,選擇 MVC5Controller-空白
//04-1-2 指定控制器名稱為HomeController,並開啟HomeController
//04-1-3 建立一般方法ShowAryDesc()-整數陣列遞減排序
//04-1-4 執行並測試 http://localhost:53468/Home/ShowAryDesc (port可能不同)
//04-1-5 建立一般方法ShowAryAsc()-整數陣列遞增排序
//04-1-6 執行並測試 http://localhost:53468/Home/ShowAryAsc (port可能不同)
//04-1-7 在Controllers資料夾上按右鍵,選擇加入,新增項目,程式碼,選擇類別,名稱鍵入Member.cs
//04-1-8 在Member class中輸入下列欄位
//04-1-9 在HomeController中建立一般方法LoginMember()
//04-1-10 執行並測試 http://localhost:53468/Home/LoginMember?uid=tom&pwd=123 (port可能不同)