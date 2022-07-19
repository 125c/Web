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
    {

        [Key]
        public int MemberID { get; set; }

        [DisplayName("姓名")]
        [StringLength(100)]
        [Required]
        public string MemberName { get; set; }

        [DisplayName("照片")]
        [MaxLength]
        public string MemberPhotoFile { get; set; }

        [DisplayName("生日")]
        [Required]
        public DateTime MemberBirthday { get; set; }

        [DisplayName("建立日期")]
        [Required]
        public DateTime CreatedDate { get; set; }


        [DisplayName("帳號")]
        [Required]
        [StringLength(20)]
        public string Account { get; set; }

        //field
        string password;  //定義一個password的field

        [DisplayName("密碼")]
        [Required]
        [DataType(DataType.Password)]

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

        [DisplayName("請再輸入一次密碼")]
        public string PwdConfirm { get; set; }

}
}