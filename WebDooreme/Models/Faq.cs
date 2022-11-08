using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
#nullable disable
namespace WebDooreme.Models
{
    [Table("Faq")]
    public partial class Faq
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Açıklama { get; set; }
    }
}
