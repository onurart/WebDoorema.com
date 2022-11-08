using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace WebDooreme.Models
{
    public class ProductDetailsViewModel
    {
        public Product Product { get; set; }
        [Required(ErrorMessage = "Ürün Adı Alanı Boş Geçilemez!")]
        public string ProductName { get; set; }
        [Required(ErrorMessage = "Ad Soyad Alanı Boş Geçilemez!")]
        public string FullName { get; set; }
        [Required(ErrorMessage = "Telefon Alanı Boş Geçilemez!")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Geçerli bir telefon numarası değil!")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Email Alanı Boş Geçilemez!")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Adres Alanı Boş Geçilemez!")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Stok Kodu Alanı Boş Geçilemez!")]
        public string StockCode { get; set; }
        public List<SubCategory>  SubCategories{ get; set; }
        public List<Category> Categories{ get; set; }
    }
}