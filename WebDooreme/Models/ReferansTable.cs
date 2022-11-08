using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebDooreme.Models
{
 
    public partial class ReferansTable
    {
        [Key]
        public int Id { get; set; }
        [StringLength(100)]
        public string Company { get; set; }
        [StringLength(100)]
        public string Province { get; set; }
        [StringLength(100)]
        public string District { get; set; }
    }
}
