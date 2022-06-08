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
        public void ShowAryDesc()
        {
            int[] score = { 10, 15, 48, 56, 87,56,7,78,29,23};
            int[] score1 = { 10, 15, 23,1,0 };
            string show = "";
            string show1 = "";
            var result = from s in score
                         orderby s descending
                         select s; //相當於select s from score by s desc           
            foreach (var item in result)
            {
                show+=item+",";
            }
            Response.Write(show);Response.Write("<hr />");
            //另一種寫法
            var result1 = score1.OrderByDescending(s => s);
            foreach (var item in result1)
            {
                show1 += item + ",";
            }//要顯示另一個ary要配另一個foreach
            Response.Write(show1);
            //return show;

        }
        public string ShowAryAsc()
        {
            int[] score = { 10, 15, 48, 56, 87, 56, 7, 78, 29, 23 };
            string show = "";
            //var result = from s in score
            //             orderby s ascending
            //             select s;
            var result = score.OrderBy(s => s);
            foreach (var item in result)
            {
                show += item + ",";
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
            //member.Name = "湯媽媽";
            //Member member2 = new Member();
            //member2.UId = "froggy";
            //member2.Pwd = "456";
            //member2.Name = "呱吉";
            //Member member3 = new Member();
            //member3.UId = "AK";
            //member3.Pwd = "789";
            //member3.Name = "台北大哥哥";

            Member[] members = new Member[]
            {
                new Member{UId="tom",Pwd="123",Name="湯媽媽"},
                new Member{UId="froggy",Pwd="456",Name="呱吉"},
                new Member{UId="ak",Pwd="789",Name="台北大哥哥"}
            };//帳號只能小寫
            //var result = (from m in members
            //              where m.UId == uid && m.pwd == "123"//注 意兩個等於跟雙引號
            //              select m.UId).FirstOrDefault();
            var result = members.Where(m => m.UId == uid && m.Pwd == pwd).FirstOrDefault();

            string show = "";
            if (result != null)
            {
                show = "welcom" + result.Name + "進入";
            }
            else
                show = "帳號或密碼錯誤！";

            return show;
        }

    }
}