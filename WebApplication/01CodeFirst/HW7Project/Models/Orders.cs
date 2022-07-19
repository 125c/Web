using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace HW7Project.Models
{
    public class Orders
    {
        [Key]
        [DisplayName("訂單編號")]
        [StringLength(12)]
        public string OrderID { get; set; }


        [DisplayName("訂單成立時間")]
        [DataType(DataType.DateTime)]
        public DateTime OrderDate { get; set; }


        [DisplayName("收貨人姓名")]
        [Required(ErrorMessage = "請填寫收貨人姓名")]
        [StringLength(30, ErrorMessage = "收貨人姓名最多30個字")]
        public string ShipName { get; set; }


        [DisplayName("收貨人地址")]
        [Required(ErrorMessage = "請填寫收貨人地址")]
        [StringLength(100, ErrorMessage = "收貨人地址最多100個字")]
        public string ShipAddress { get; set; }

        [DisplayName("出貨日")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public Nullable<DateTime> ShippedDate { get; set; }

        //Forign Key
        public int ShipID { get; set; }
        public int PayTypeID { get; set; }
        public int EmployeeID { get; set; }
        public int MemberID { get; set; }


        //拉關聯
        public virtual Shippers Shipper { get; set; }
        public virtual PayTypes PayType { get; set; }
        public virtual Employees Employee { get; set; }
        public virtual Members Member { get; set; }

    }
}