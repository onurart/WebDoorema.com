using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
#nullable disable
namespace WebDooreme.Models
{
    [Table("Technical")]
    public partial class Technical
    {
        [Key]
        public int Id { get; set; }
        [StringLength(100)]
        public string Tİtle { get; set; }
        public string Aciklama { get; set; }
        [StringLength(100)]
        public string Title2 { get; set; }
        public string Acıklama2 { get; set; }
        public string İmages { get; set; }
        public string Aİmages { get; set; }
        public string Images2 { get; set; }
        [Column("AImages2")]
        public string Aimages2 { get; set; }
        public string Images3 { get; set; }
        [Column("AImages3")]
        public string Aimages3 { get; set; }
        public string Images4 { get; set; }
        [Column("AImages4")]
        public string Aimages4 { get; set; }
    }
}
