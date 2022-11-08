using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
#nullable disable
namespace WebDooreme.Models
{
    [Keyless]
    [Table("Meta", Schema = "sifataki")]
    public partial class Metum
    {
        [Column("MetaID")]
        public int MetaId { get; set; }
        [Column(TypeName = "text")]
        public string Description { get; set; }
        [Column(TypeName = "text")]
        public string Keywords { get; set; }
    }
}
