using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace HW7Project.Models
{
    public class Products
    {
        [Key]
        [DisplayName("商品編號")]
        [StringLength(6)]
        [RegularExpression("[A-F][0-9]{5}")]
        public string ProductID { get; set; }

        [DisplayName("商品名稱")]
        [Required(ErrorMessage = "請輸入商品名稱")]
        [StringLength(40, ErrorMessage = "商品名稱最多40個字")]
        public string ProductName { get; set; }

        [DisplayName("商品照片")]
        [Required(ErrorMessage = "請上傳商品照片")]
        [MaxLength]
        public byte[] PhotoFile { get; set; }

        [HiddenInput(DisplayValue = false)]
        [StringLength(20)]
        public string ImageMimeType { get; set; }

        [DisplayName("商品單價")]
        [Required(ErrorMessage = "請輸入商品單價")]
        [Range(0, short.MaxValue, ErrorMessage = "單價不可小於0")]
        public short UnitPrice { get; set; }

        [DisplayName("商品說明")]
        [Required(ErrorMessage = "請輸入商品說明")]
        [StringLength(1000, ErrorMessage = "商品介紹不得超過1000字")]
        public string Description { get; set; }

        [DisplayName("庫存量")]
        [Required(ErrorMessage = "請輸入庫存量")]
        [Range(0, short.MaxValue, ErrorMessage = "庫存量不可小於0")]
        public short UnitsInStock { get; set; }

        [DisplayName("是否在架上")]
        [DefaultValue(false)]
        public bool Discontinued { get; set; }

        [DisplayName("建立日期")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime CreatedDate { get; set; }
    }
}