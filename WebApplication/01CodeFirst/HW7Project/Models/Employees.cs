using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace HW7Project.Models
{
    public class Employees
    {
        [Key]
        public int EmployeesID { get; set; }

        [Required(ErrorMessage ="請填寫員工姓名")]
        [StringLength(100,ErrorMessage = "員工姓名不超過100字")]
        [DisplayName("員工姓名")]
        public string EmployeeName { get; set; }

        [DisplayName("建立日期")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:yyyy-MM-dd}",ApplyFormatInEditMode =true)]
        public DateTime CreatedDate { get; set; }

        [DisplayName("帳號")]
        [Required(ErrorMessage = "請填寫帳號")]
        [StringLength(20, ErrorMessage = "帳號不得超過20字")]
        [RegularExpression("[A-Za-z][A-Za-z0-9]{4,19}", ErrorMessage = "帳號格式錯誤")]
        public string Account { get; set; }

        [DisplayName("密碼")]
        [Required(ErrorMessage = "請填寫密碼")]
        [DataType(DataType.Password)]
        [MinLength(8, ErrorMessage = "密碼最少8碼")]
        [MaxLength(20, ErrorMessage = "密碼最多20碼")]
        public string Password { get; set; }
    }
}