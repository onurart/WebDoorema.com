using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
#nullable disable
namespace WebDooreme.Models
{
    [Keyless]
    public partial class Comment
    {
        [Column("CommentID")]
        public int CommentId { get; set; }
        [Column(TypeName = "text")]
        public string CommentDetail { get; set; }
        [StringLength(50)]
        public string ProductName { get; set; }
        public bool? Status { get; set; }
        [StringLength(50)]
        public string CommentMail { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CommentDate { get; set; }
        [StringLength(100)]
        public string CommentName { get; set; }
    }
}
