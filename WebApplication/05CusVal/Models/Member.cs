using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _05CusVal.Models
{
    public class Member
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "身分證字號必填")]
        [RegularExpression("[A-Za-z][12][0-9]{8}", ErrorMessage = "身份證字號格式錯誤")]
        [CheckIDNumber(ErrorMessage ="不合法的身份證字號")]
        //如果這裡沒有寫ErrorMessage，顯示建構子的內容，如果沒有建構子，顯示ValidationAttribute的內容
        public string IDNumber { get; set; }
        public class CheckIDNumber : ValidationAttribute
        //CheckIDNumber是一種 ValidationAttribute ，只是我叫CheckIDNumber。
        //繼承= is a  。烤雞是雞、炸雞是雞，雞比烤/炸具體，炸繼承雞

        {
            public CheckIDNumber()
                //建構子
            {
                ErrorMessage = "不要亂填";
            }

            public override bool IsValid(object value)
            //object value 某一種功能 IsValid功能是return有沒有驗證通過
            //override 原本沒有寫的東西覆寫掉
            {
                int sum = 0;
                string id =value.ToString();
                const string eng = "ABCDEFGHJKLMNPQRSTUVXYWZIO";
                string t = id.Substring(0, 1).ToUpper();//從第0個位置抓1碼。加上ToUpper()讓輸入小寫轉大寫
                int intEng=eng.IndexOf(t)+10;//A換成10 G第6個位置，換成16
                int n1 = intEng / 10,n2 = intEng % 10;//把英文字轉換後的數字拆開
                int[]a=new int[9];//給後面9個數字用，有9個，索引值是0-8                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       
                for(int i=0; i<a.Length; i++)
                {
                    a[i] = Convert.ToInt32(id.Substring(i + 1, 1));
                }
                //sum = n1 + n2 * 9 + a[0] * 8 + a[1] * 7 + a[2] * 6 + a[3] * 5 + a[4] * 4 + a[5] * 3 + a[6] * 2 + a[7] + a[8];
                //換成迴圈↓
                sum = n1 + n2 * 9 + a[8];
                for(int i=0;i<8;i++)
                {
                    sum+=a[i]*(8-i);
                }

                //int[] uid = new int[10];

                //for (int i = 1; i < user_id.Length; i++)
                //{
                //    uid[i] = Convert.ToInt32(user_id.Substring(i, 1));
                //}
                //switch (id.Substring(0, 1).ToUpper())
                //{
                //    case "A": uid[0] = 10; break;
                //    case "B": uid[0] = 11; break;
                //    case "C": uid[0] = 12; break;
                //    case "D": uid[0] = 13; break;
                //    case "E": uid[0] = 14; break;
                //    case "F": uid[0] = 15; break;
                //    case "G": uid[0] = 16; break;
                //    case "H": uid[0] = 17; break;
                //    case "I": uid[0] = 34; break;
                //    case "J": uid[0] = 18; break;
                //    case "K": uid[0] = 19; break;
                //    case "L": uid[0] = 20; break;
                //    case "M": uid[0] = 21; break;
                //    case "N": uid[0] = 22; break;
                //    case "O": uid[0] = 35; break;
                //    case "P": uid[0] = 23; break;
                //    case "Q": uid[0] = 24; break;
                //    case "R": uid[0] = 25; break;
                //    case "S": uid[0] = 26; break;
                //    case "T": uid[0] = 27; break;
                //    case "U": uid[0] = 28; break;
                //    case "V": uid[0] = 29; break;
                //    case "W": uid[0] = 32; break;
                //    case "X": uid[0] = 30; break;
                //    case "Y": uid[0] = 31; break;
                //    case "Z": uid[0] = 33; break;
                //}

                if (sum % 10 == 0)
                    return true;
                return false;

            }
            
        }




        [Required(ErrorMessage = "姓名必填")]
        [StringLength(20,ErrorMessage ="姓名最長20個字")]
        public string Name { get; set; }
    }
}