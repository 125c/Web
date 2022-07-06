using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace HW5.Models
{
    public class Member
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("輸入身份證字號")]
        [Required(ErrorMessage = "身分證字號必填")]
        [RegularExpression("[A-Za-z][12][0-9]{8}", ErrorMessage = "身份證字號格式錯誤")]
        [CheckIDNumber(ErrorMessage = "不合法的身份證字號")]
        public string IDNumber { get; set; }
        public class CheckIDNumber : ValidationAttribute

        {
            public CheckIDNumber()
            {
                ErrorMessage = "不要亂填";
            }

            public override bool IsValid(object value)
            {
                int sum = 0;
                string id = value.ToString();
                const string eng = "ABCDEFGHJKLMNPQRSTUVXYWZIO";
                string t = id.Substring(0, 1).ToUpper();
                int intEng = eng.IndexOf(t) + 10;
                int n1 = intEng / 10, n2 = intEng % 10;
                int[] a = new int[9];                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       
                for (int i = 0; i < a.Length; i++)
                {
                    a[i] = Convert.ToInt32(id.Substring(i + 1, 1));
                }
                sum = n1 + n2 * 9 + a[8];
                for (int i = 0; i < 8; i++)
                {
                    sum += a[i] * (8 - i);
                }
                if (sum % 10 == 0)
                    return true;
                return false;
            }
        }
        [DisplayName("輸入姓名")]
        [Required(ErrorMessage = "姓名必填")]
        [StringLength(20, ErrorMessage = "姓名最長20個字")]
        public string Name { get; set; }
    }
}