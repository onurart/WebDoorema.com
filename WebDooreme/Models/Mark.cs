using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
#nullable disable
namespace WebDooreme.Models
{
    [Keyless]
    [Table("Marks", Schema = "sifataki")]
    public partial class Mark
    {
        [Column("MarkID")]
        public int MarkId { get; set; }
        [StringLength(50)]
        public string MarkName { get; set; }
        [Column(TypeName = "text")]
        public string Description { get; set; }
    }
}
