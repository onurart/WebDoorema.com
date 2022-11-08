using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
#nullable disable
namespace WebDooreme.Models
{
    [Keyless]
    public partial class SubCategory
    {
        [Column("SubCategoryID")]
        public int SubCategoryId { get; set; }
        [Column("CategoryID")]
        public int? CategoryId { get; set; }
        [StringLength(50)]
        public string SubCategoryName { get; set; }
        [StringLength(1000)]
        public string Description { get; set; }
        [StringLength(50)]
        public string Image { get; set; }
        [StringLength(70)]
        public string MetaTitle { get; set; }
        [StringLength(160)]
        public string MetaDesc { get; set; }
        [StringLength(260)]
        public string MetaKeywords { get; set; }
        public int? DisplayOrder { get; set; }
        [ForeignKey(nameof(CategoryId))]
        public virtual Category Category { get; set; }
    }
}
