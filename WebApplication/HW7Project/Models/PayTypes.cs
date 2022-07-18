using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace HW7Project.Models
{
    public class PayTypes
    {
        [Key] 
        public int PayTypeId { get; set; }
        [DisplayName("付款方式")]
        [Required(ErrorMessage ="請輸入付款方式")]
        [StringLength(10,ErrorMessage ="付款方式最多10個字")]
        public String PayTypeName { get; set; }
    }
}