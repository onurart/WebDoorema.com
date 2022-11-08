using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
#nullable disable
namespace WebDooreme.Models
{
    [Table("SubCategoryClass")]
    public partial class SubCategoryClass
    {
        public SubCategoryClass()
        {
            Products = new HashSet<Product>();
        }
        [Key]
        [Column("SubCategoryClassID")]
        public int SubCategoryClassId { get; set; }
        [Column("CategoryID")]
        public int? CategoryId { get; set; }
        [Column("SubCategoryID")]
        public int? SubCategoryId { get; set; }
        [StringLength(50)]
        public string SubClassName { get; set; }
        [StringLength(1000)]
        public string Description { get; set; }
        [StringLength(50)]
        public string Image { get; set; }
        public int? DisplayOrder { get; set; }
        [ForeignKey(nameof(CategoryId))]
        [InverseProperty("SubCategoryClasses")]
        public virtual Category Category { get; set; }
        [InverseProperty(nameof(Product.SubCategoryClass))]
        public virtual ICollection<Product> Products { get; set; }
    }
}
