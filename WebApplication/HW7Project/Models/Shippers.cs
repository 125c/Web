using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace HW7Project.Models
{
    public class Shippers
    {
        [Key]
        public int ShipId { get; set; }
        [DisplayName("運送方式")]
        [Required(ErrorMessage ="請輸入運送方式")]
        [StringLength(20,ErrorMessage ="運中方式最多20個字")]
        public String ShipVia { get; set; }
    }
}