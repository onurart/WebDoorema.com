using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
#nullable disable
namespace WebDooreme.Models
{
    [Keyless]
    [Table("MailList", Schema = "sifataki")]
    public partial class MailList
    {
        [Column("MailID")]
        public int MailId { get; set; }
        [StringLength(50)]
        public string MailName { get; set; }
        [StringLength(50)]
        public string MailAddress { get; set; }
    }
}
