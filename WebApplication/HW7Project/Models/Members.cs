using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;

namespace HW7Project.Models
{
    public class Members
    {
        [Key]
        public int MemberId { get; set; }

        [DisplayName("姓名")]
        [StringLength(100,ErrorMessage ="姓名超過100也太誇張")]
        [Required]
        public String MemberName { get; set; }
        [DisplayName("照片")]
        [MaxLength]
        public byte[] MemberPhotoFile { get; set; }
        [DisplayName("會員生日")]
        [Required]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yy/MM/dd hh:mm;ss}", ApplyFormatInEditMode = true)]
        public DateTime MemberBirthday { get; set; }
        [DisplayName("建立日期")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yy/MM/dd hh:mm;ss}", ApplyFormatInEditMode = true)]
        public DateTime CreateDate { get; set; }
        [DisplayName("帳號")]
        [Required]
        [StringLength(20, ErrorMessage = "帳號超過20個你記得住？")]
        public String Account { get; set; }
        string password;
        [DisplayName("密碼")]
        [Required]
        [DataType(DataType.Password)]
        //[MinLength(8, ErrorMessage = "密碼最少8碼")]//雜湊就不用設定長度，會變
        //[MaxLength(20, ErrorMessage = "密碼最多20碼")]
        public String Password {
            get {
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

    }
}