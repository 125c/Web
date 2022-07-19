using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HW7Project.Models
{
    public class OrderDetails
    {
        [Key]
        [DisplayName("訂單編號")]
        [Column(Order =1)]
        public string OrderID { get; set; }

        [Key]
        [DisplayName("商品編號")]
        [Column(Order = 2)]
        public string ProductID { get; set; }

        [DisplayName("商品單價")]
        [Required(ErrorMessage = "請輸入商品單價")]
        [Range(0, short.MaxValue, ErrorMessage = "單價不可小於0")]
        public short UnitPrice { get; set; }

        [DisplayName("數量")]
        [Required(ErrorMessage = "請輸入商品數量")]
        [Range(0, short.MaxValue, ErrorMessage = "數量不可小於0")]
        public short Quantity { get; set; }

        //拉關聯
        public virtual Orders Order { get; set; }
        public virtual Products Product { get; set; }
    }
}