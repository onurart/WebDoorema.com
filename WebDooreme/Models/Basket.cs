using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
#nullable disable
namespace WebDooreme.Models
{
    [Keyless]
    [Table("Basket")]
    public partial class Basket
    {
        [Column("BasketID")]
        public int BasketId { get; set; }
        [Column("ProductID")]
        public int? ProductId { get; set; }
        [StringLength(100)]
        public string UserName { get; set; }
        [StringLength(100)]
        public string ProductName { get; set; }
        [StringLength(100)]
        public string StockCode { get; set; }
        [StringLength(50)]
        public string ItemName { get; set; }
        public int? Amount { get; set; }
        public int? Tax { get; set; }
        [Column(TypeName = "money")]
        public decimal? UnitPrice { get; set; }
        [Column(TypeName = "money")]
        public decimal? TotalPrice { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? BasketDate { get; set; }
        public bool? Status { get; set; }
    }
}
