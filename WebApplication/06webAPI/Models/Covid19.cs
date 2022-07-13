using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _06webAPI.Models
{

    public class Covid19
    //{"id":"ID","a01":"個案研判日","a02":"個案公佈日","a03":"縣市別","a04":"區域","a05":"新增確診人數","a06":"累計確診人數"}
    {
        [DisplayName("id")]
        public string id { get; set; }


        [DisplayName("個案研判日")]
        public string a01 { get; set; }


        [DisplayName("個案公佈日")]
        public string a02 { get; set; }


        [DisplayName("縣市")]
        public string a03 { get; set; }


        [DisplayName("區域")]
        public string a04 { get; set; }


        [DisplayName("新增確診人數")]
        public string a05 { get; set; }


        [DisplayName("累計確診人數")]
        public string a06 { get; set; }
      

    }

}