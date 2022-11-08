using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
#nullable disable
namespace WebDooreme.Models
{

    [Table("References", Schema = "sifataki")]
    public partial class Reference
    {
        [Key]
        [Column("ReferenceID")]
        public int ReferenceId { get; set; }
        [StringLength(100)]
        public string ReferenceName { get; set; }
        [StringLength(100)]
        public string ReferenceType { get; set; }
        [StringLength(100)]
        public string ReferenceImage { get; set; }
        [StringLength(100)]
        public string ReferenceThumb1 { get; set; }
        [StringLength(100)]
        public string ReferenceThumb2 { get; set; }
        [StringLength(100)]
        public string ReferenceThumb3 { get; set; }
        [StringLength(100)]
        public string ReferenceThumb4 { get; set; }
    }
}