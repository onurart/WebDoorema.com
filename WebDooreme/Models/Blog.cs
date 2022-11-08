using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
#nullable disable
namespace WebDooreme.Models
{
    [Table("Blog")]
    public partial class Blog
    {
        [Key]
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        [StringLength(100)]
        public string Title { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreateDate { get; set; }
        public string Description { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }
    }
}
