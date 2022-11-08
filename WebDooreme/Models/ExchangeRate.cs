using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
#nullable disable
namespace WebDooreme.Models
{
    [Keyless]
    public partial class ExchangeRate
    {
        [Column("ExchangeID")]
        public int ExchangeId { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ExchangeDay { get; set; }
        [Column(TypeName = "money")]
        public decimal? DollarPrice { get; set; }
        [Column(TypeName = "money")]
        public decimal? EuroPrice { get; set; }
    }
}
