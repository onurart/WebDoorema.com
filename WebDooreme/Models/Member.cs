using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
#nullable disable
namespace WebDooreme.Models
{
    public partial class Member
    {
        [Key]
        [Column("MemberID")]
        public int MemberId { get; set; }
        [StringLength(100)]
        public string MemberName { get; set; }
        [StringLength(50)]
        public string UserName { get; set; }
        [StringLength(50)]
        public string Password { get; set; }
        public int? Auth { get; set; }
        public bool? Status { get; set; }
    }
}
