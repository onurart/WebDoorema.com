using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
#nullable disable
namespace WebDooreme.Models
{
    [Table("Institutional")]
    public partial class Institutional
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string Tİtle { get; set; }
        public string İmages { get; set; }
        public string Açıklama { get; set; }
    }
}
