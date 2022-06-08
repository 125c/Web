using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace _02View.Models
{
    public class Member
    {
        [DisplayName("使用者帳號")]
        [Required]
        public string UserId { get; set; }
        [DisplayName("使用者密碼")]
        [Required]
        public string Pwd { get; set; }
        [DisplayName("使用者名稱")]
        public string Name { get; set; }
        [DisplayName("使用者信箱")]
        [Required]
        public string Email { get; set; }
        [DisplayName("生日")]
        public DateTime Birthday { get; set; }
    }
}