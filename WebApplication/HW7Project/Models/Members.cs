using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Security.Cryptography;

namespace HW7Project.Models
{
    public class Members
    {   [Key]
        [DisplayName("會員編號")]
        public int MemberId { get; set; }

        [DisplayName("姓名")]
        [StringLength(100,ErrorMessage ="姓名超過100也太誇張")]
        [Required]
        public string MemberName { get; set; }
        [DisplayName("照片")]
        [MaxLength]
        public string MemberPhotoFile { get; set; }
        [DisplayName("會員生日")]
        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        //[DataType(DataType.DateTime)]
        public DateTime MemberBirthday { get; set; }
        [DisplayName("建立日期")]
        [Required]//        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime CreatedDate { get; set; }
        [DisplayName("帳號")]
        [Required]
        [StringLength(20, ErrorMessage = "帳號超過20個你記得住？")]
        [CheckAccount]
        public string Account { get; set; }
        //field
        string password;//定義一個password的field
        [DisplayName("密碼")]
        [Required]
        [DataType(DataType.Password)]
        //[MinLength(8, ErrorMessage = "密碼最少8碼")]//雜湊就不用設定長度，會變
        //[MaxLength(20, ErrorMessage = "密碼最多20碼")]
        public string Password 
        {
            get 
            {
                return password;
            }
            set
            {
                byte[] hashValue;
                string result = "";
                System.Text.UnicodeEncoding ue= new System.Text.UnicodeEncoding();
                byte[] pwBytes = ue.GetBytes(value);
                SHA256 shHash=SHA256.Create();
                hashValue=shHash.ComputeHash(pwBytes);
                foreach (byte b in hashValue)
                {
                    result += b.ToString();
                }
                password = result;
            }
        }
        //自訂驗證規則的寫法
        public class CheckAccount : ValidationAttribute 
        {
            public CheckAccount()
            {
                ErrorMessage = "這個帳號有人在用了～～";
            }
            public override bool IsValid(object value)
            {
                if (value == null)
                    value = "@#$";
                HW7ProjectContext db = new HW7ProjectContext();
                var account= db.Members.Where(m => m.Account == value.ToString()).FirstOrDefault();
                //return base.IsValid(value);
                return (account==null)?true:false;
            }
        }
    }
}