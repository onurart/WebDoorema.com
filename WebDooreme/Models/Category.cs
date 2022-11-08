using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
#nullable disable
namespace WebDooreme.Models
{
    public partial class Category
    {
        public Category()
        {
            Products = new HashSet<Product>();
            SubCategoryClasses = new HashSet<SubCategoryClass>();
        }
        [Key]
        [Column("CategoryID")]
        public int CategoryId { get; set; }
        [StringLength(50)]
        public string CategoryName { get; set; }
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
        [InverseProperty(nameof(Product.Category))]
        public virtual ICollection<Product> Products { get; set; }
        [InverseProperty(nameof(SubCategoryClass.Category))]
        public virtual ICollection<SubCategoryClass> SubCategoryClasses { get; set; }
    }
}
