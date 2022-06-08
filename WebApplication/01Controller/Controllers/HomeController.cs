using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _01Controller.Controllers
{
    public class HomeController : Controller
    {
        //修飾詞 public protected private
        public string ShowAry()
        {
            int[] score = { 10, 15, 48, 56, 87 };
            int sum = 0;
            string show = "";
            foreach(int s in score)
            {
                sum += s;
                show += s + ",";
            }
            show += "成績總和:" + sum;
            return show;
        }
        public string ShowImg()
        {
            string show = "";
            for (int i = 1;i<= 8; i++){
                show += "<img sre='../01Controller素材/images/" + i + ".jpg' />";
            }
            return show;
        }
        public string ShowImgIdx(int idx) 
        {
            string show = "";
            string[] name = { "櫻桃鴨", "鴨油高麗菜", "鴨油麻婆豆腐", "櫻桃鴨握壽司","片皮鴨捲三星蔥", "三杯鴨", "櫻桃鴨片肉", "慢火白菜燉鴨湯"};
            //一般寫法
            //show = "<p style='text-align:center'><img src ='../01Controller素材/images/" + idx+".jpg'/><h3 style='text-align:center'>"+name[idx-1]+"</h3></p>";
            //字串格式化寫法
            show = string.Format("<p style='text-aiign:center'><img src='../01Controller素材/images/'/><h3 style='text-aiign:center'>{0}<h3/></p>", idx, name[idx - 1]);
            show += "<br><a href='ShowImages'>回菜菜列表</a>";
            return show;
        }

    }
}