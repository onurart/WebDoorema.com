using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebDooreme.Models
{
    [Table("Slider")]
    public partial class Slider
    {
        [Key]
        [Column("SiderID")]
        public int SiderId { get; set; }
        [StringLength(50)]
        public string Url { get; set; }
        [StringLength(100)]
        public string Image { get; set; }
        [StringLength(200)]
        public string Description { get; set; }
        [Column("ProductID")]
        public int? ProductId { get; set; }
    }
}
