using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using WebDooreme.Models;
namespace WebDooreme.Components
{
    public class ProductCategoriesMenu : ViewComponent
    {
        private readonly sifatakiContext _db;
        public ProductCategoriesMenu(sifatakiContext db)
        {
            _db = db;
        }
        public async Task<IViewComponentResult> InvokeAsync(int? categoryId,int? subCategoryId)
        {
            if (categoryId != null)
            {
                if (subCategoryId != null)
                {
                    var cate = await _db.Categories.OrderBy(x => x.DisplayOrder).ToListAsync();
                    var pro = await _db.SubCategories.OrderBy(x => x.DisplayOrder).ToListAsync();
                    var productViewModel = new MenuCategoiesViewModel
                    {
                        Categories = cate,
                        Sub = pro,
                        SelectedCategory = cate.FirstOrDefault(m => m.CategoryId == categoryId).CategoryName,
                        SelectedSubCategory=pro.FirstOrDefault(m=>m.SubCategoryId==subCategoryId).SubCategoryName
                    };
                    return View(productViewModel);
                }
                else
                {
                    var cate = await _db.Categories.OrderBy(x => x.DisplayOrder).ToListAsync();
                    var pro = await _db.SubCategories.OrderBy(x => x.DisplayOrder).ToListAsync();
                    var productViewModel = new MenuCategoiesViewModel
                    {
                        Categories = cate,
                        Sub = pro,
                        SelectedCategory = cate.FirstOrDefault(m => m.CategoryId == categoryId).CategoryName,
                        SelectedSubCategory=null
                    };
                    return View(productViewModel);
                }
               
            }
            else
            {
                var cate = await _db.Categories.OrderBy(x => x.DisplayOrder).ToListAsync();
                var pro = await _db.SubCategories.OrderBy(x => x.DisplayOrder).ToListAsync();
                var productViewModel = new MenuCategoiesViewModel
                {
                    Categories = cate,
                    Sub = pro,
                    SelectedCategory = null,
                };
                return View(productViewModel);
            }
            
        }
    }
}