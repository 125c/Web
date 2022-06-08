using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _02View.Models
{
    public class NightMarket
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int price { get; set; }
    }
}/*model提供資料來源………只有它有接到資料庫，但是這次並沒有資料庫，它是一個模子，做成有3個屬性的物件*/