using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
#nullable disable
namespace WebDooreme.Models
{
    [Keyless]
    [Table("Outlets", Schema = "sifataki")]
    public partial class Outlet
    {
        [Column("OutletID")]
        public int OutletId { get; set; }
        [StringLength(50)]
        public string OutletName { get; set; }
        [StringLength(50)]
        public string OutletSemt { get; set; }
        [StringLength(50)]
        public string OutletCity { get; set; }
        [Column(TypeName = "text")]
        public string OutletAddress { get; set; }
        [Column(TypeName = "text")]
        public string OutletMapCode { get; set; }
        [StringLength(10)]
        public string OutletTelCode { get; set; }
        [StringLength(50)]
        public string OutletTel { get; set; }
        [StringLength(10)]
        public string OutletFaxCode { get; set; }
        [StringLength(50)]
        public string OutletFax { get; set; }
        [StringLength(50)]
        public string OutletMail { get; set; }
        [StringLength(100)]
        public string OutletAuth { get; set; }
    }
}
