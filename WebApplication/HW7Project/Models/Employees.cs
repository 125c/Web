using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;

namespace HW7Project.Models
{
    public class Employees
    {
        [Key]
        [Required(ErrorMessage = "員工編號")]
        public int EmployeesId { get; set; }
        /// 
        [Required(ErrorMessage = "員工姓名")]
        [StringLength(100, ErrorMessage = "員工姓名不得超過100字")]
        [DisplayName("員工姓名")]
        public String EmployeesName { get; set; }
        /// 
        [DisplayName("建立日期")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:yy/MM/dd hh:mm;ss}",ApplyFormatInEditMode =true)]
        ///
        public DateTime CreatedDate { get; set; }
        [Required(ErrorMessage = "帳號一定要有")]
        [DisplayName("帳號")]
        [RegularExpression("[A-Za-z][A-Za-z0-9]{4,19}",ErrorMessage =("帳號格式錯誤，要英文大小寫開頭"))]
        public String Account { get; set; }
        string password;
        [Required(ErrorMessage = "密碼一定要有")]
        [DisplayName("密碼")]
        [DataType(DataType.Password)]
        public String Password
        {
            get
            {
                return password;
            }
            set
            {
                byte[] hashValue;
                string result = "";
                System.Text.UnicodeEncoding ue = new System.Text.UnicodeEncoding();
                byte[] pwBytes = ue.GetBytes(value);
                SHA256 shHash = SHA256.Create();
                hashValue = shHash.ComputeHash(pwBytes);
                foreach (byte b in hashValue)
                {
                    result += b.ToString();
                }
                password = result;
            }
        }
    }
}