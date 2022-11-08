using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
#nullable disable
namespace WebDooreme.Models
{
    [Keyless]
    [Table("Visitors", Schema = "sifataki")]
    public partial class Visitor
    {
        [Column("VisitorID")]
        public int VisitorId { get; set; }
        [StringLength(20)]
        public string VisitorIp { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? VisitDate { get; set; }
        [StringLength(50)]
        public string VisitorLocation { get; set; }
        public bool? Status { get; set; }
    }
}
