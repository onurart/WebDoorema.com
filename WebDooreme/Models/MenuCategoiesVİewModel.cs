using System.Collections.Generic;
namespace WebDooreme.Models
{
    public class MenuCategoiesViewModel
    {
        public List<Category> Categories { get; set; }
        public List<SubCategory> Sub { get; set; }
        public List<Product> Product { get; set; }
        public string SelectedCategory { get; set; }
        public string SelectedSubCategory { get; set; }
    }
}