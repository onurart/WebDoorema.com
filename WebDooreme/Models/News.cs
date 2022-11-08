using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
#nullable disable
namespace WebDooreme.Models
{
    [Keyless]
    public partial class News
    {
        [Column("NewsID")]
        public int NewsId { get; set; }
        [StringLength(50)]
        public string NewsName { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? NewsDate { get; set; }
        [Column(TypeName = "text")]
        public string NewsDetails { get; set; }
        [StringLength(100)]
        public string NewsImage { get; set; }
        public bool? Status { get; set; }
        public int? NewsNumber { get; set; }
    }
}
