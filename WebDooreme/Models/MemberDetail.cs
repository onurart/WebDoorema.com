using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
#nullable disable
namespace WebDooreme.Models
{
    [Keyless]
    public partial class MemberDetail
    {
        [Column("MemberID")]
        public int? MemberId { get; set; }
        [StringLength(50)]
        public string UserName { get; set; }
        [StringLength(100)]
        public string MemberName { get; set; }
        [StringLength(50)]
        public string MemberCity { get; set; }
        [StringLength(50)]
        public string MemberSemt { get; set; }
        [Column(TypeName = "text")]
        public string MemberAddress { get; set; }
        public int? MemberTelCode { get; set; }
        public int? MemberTel { get; set; }
        public int? MemberGsmCode { get; set; }
        public int? MemberGsm { get; set; }
        [StringLength(50)]
        public string MemberTaxOffice { get; set; }
        public long? MemberTaxNo { get; set; }
        public int? MemberRole { get; set; }
        public bool? Status { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? MemberBirthday { get; set; }
        public bool? MemberSex { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? LastVisit { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? FirstVisit { get; set; }
        [ForeignKey(nameof(MemberId))]
        public virtual Member Member { get; set; }
    }
}
