using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
#nullable disable
namespace WebDooreme.Models
{
    [Keyless]
    [Table("Revenues", Schema = "sifataki")]
    public partial class Revenue
    {
        [Column("RevenueID")]
        public int RevenueId { get; set; }
        [StringLength(100)]
        public string MemberName { get; set; }
        [StringLength(50)]
        public string RevenueType { get; set; }
        [Column(TypeName = "money")]
        public decimal? RevenueValue { get; set; }
        [StringLength(50)]
        public string RevenuePoint { get; set; }
        public bool? Status { get; set; }
    }
}
