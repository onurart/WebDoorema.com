using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
#nullable disable
namespace WebDooreme.Models
{
    [Keyless]
    public partial class Order
    {
        [Column("OrderID")]
        public int OrderId { get; set; }
        [StringLength(100)]
        public string UserName { get; set; }
        [StringLength(50)]
        public string OrderNumber { get; set; }
        [StringLength(100)]
        public string ProductName { get; set; }
        [StringLength(50)]
        public string ItemName { get; set; }
        public int? Amount { get; set; }
        [Column(TypeName = "money")]
        public decimal? UnitPrice { get; set; }
        [Column(TypeName = "money")]
        public decimal? TotalPrice { get; set; }
        public int? Tax { get; set; }
        [StringLength(100)]
        public string MemberName { get; set; }
        [Column(TypeName = "text")]
        public string OrderAddress { get; set; }
        [StringLength(50)]
        public string OrderCity { get; set; }
        [StringLength(50)]
        public string OrderSemt { get; set; }
        [StringLength(50)]
        public string OrderTelCode { get; set; }
        [StringLength(50)]
        public string OrderTel { get; set; }
        [StringLength(50)]
        public string OrderGsmCode { get; set; }
        [StringLength(50)]
        public string OrderGsm { get; set; }
        [StringLength(50)]
        public string OrderPaymentType { get; set; }
        [StringLength(50)]
        public string OrderCargoFirm { get; set; }
        [Column(TypeName = "text")]
        public string OrderNote { get; set; }
        [StringLength(50)]
        public string TaxOffice { get; set; }
        [StringLength(50)]
        public string TaxNumber { get; set; }
        public bool? Status { get; set; }
        [StringLength(50)]
        public string DeliveryTime { get; set; }
        public bool? DeliveryPackage { get; set; }
    }
}
