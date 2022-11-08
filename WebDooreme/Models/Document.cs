using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
#nullable disable
namespace WebDooreme.Models
{
    public partial class Document
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        public string Images { get; set; }
        [Column("AImages")]
        public string Aimages { get; set; }
    }
}
