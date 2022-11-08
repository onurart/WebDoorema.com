using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
#nullable disable
namespace WebDooreme.Models
{
    [Keyless]
    [Table("Temp", Schema = "sifataki")]
    public partial class Temp
    {
        [Column("ProductID")]
        public int? ProductId { get; set; }
        [Column("CategoryID")]
        public int? CategoryId { get; set; }
        [Column("SubCategoryID")]
        public int? SubCategoryId { get; set; }
        [Column("SubCategoryClassID")]
        public int? SubCategoryClassId { get; set; }
        [StringLength(50)]
        public string ItemName { get; set; }
        [StringLength(50)]
        public string StockCode { get; set; }
        public int? StockUnit { get; set; }
        [StringLength(100)]
        public string ProductName { get; set; }
        [StringLength(50)]
        public string Mark { get; set; }
        [Column(TypeName = "text")]
        public string Keywords { get; set; }
        [Column(TypeName = "text")]
        public string Description { get; set; }
        [Column(TypeName = "text")]
        public string InstallmentTabel { get; set; }
        [Column(TypeName = "money")]
        public decimal? Price { get; set; }
        [Column(TypeName = "money")]
        public decimal? DiscountPrice { get; set; }
        [Column(TypeName = "money")]
        public decimal? DiscountPrice2 { get; set; }
        [Column(TypeName = "money")]
        public decimal? DiscountPrice3 { get; set; }
        [Column(TypeName = "money")]
        public decimal? RelegatePrice { get; set; }
        [Column(TypeName = "money")]
        public decimal? CargoPrice { get; set; }
        [Column(TypeName = "money")]
        public decimal? LastPrice { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal? CargoDiamension { get; set; }
        [StringLength(100)]
        public string Image { get; set; }
        [StringLength(100)]
        public string ImageDetails { get; set; }
        [StringLength(100)]
        public string Thumbnail1 { get; set; }
        [StringLength(100)]
        public string Thumbnail2 { get; set; }
        [StringLength(100)]
        public string Thumbnail3 { get; set; }
        public int? Tax { get; set; }
        [Column(TypeName = "text")]
        public string ProductDetail { get; set; }
        [Column(TypeName = "text")]
        public string ProductWords { get; set; }
        public bool? Campaign { get; set; }
        public bool? NewProduct { get; set; }
        public bool? PopulateProduct { get; set; }
        public bool? DiscountProduct { get; set; }
        public bool? SpecialProduct { get; set; }
        public bool? MainPageProduct { get; set; }
        public bool? RecomandedProduct { get; set; }
        public int? ViewCase { get; set; }
    }
}
