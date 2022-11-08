using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
#nullable disable
namespace WebDooreme.Models
{
    [Table("DisCount")]
    public partial class DisCount
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string ProductName { get; set; }
        [StringLength(50)]
        public string StockCode { get; set; }
        [StringLength(500)]
        public string Explanation { get; set; }
        public string Images { get; set; }
        [StringLength(50)]
        public string Features { get; set; }
        [StringLength(50)]
        public string Features2 { get; set; }
        [StringLength(50)]
        public string Features3 { get; set; }
        [StringLength(50)]
        public string Features4 { get; set; }
        [StringLength(50)]
        public string Features5 { get; set; }
        public int? ProductId { get; set; }
    }
}
