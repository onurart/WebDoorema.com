using Microsoft.AspNetCore.Mvc;
using System;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using WebDooreme.Models;
namespace WebDooreme.Components
{
    public class ProductList : ViewComponent
    {
        private readonly sifatakiContext _db;
        public ProductList(sifatakiContext db)
        {
            _db = db;
        }
#pragma warning disable CS1998 // This async method lacks 'await' operators and will run synchronously. Consider using the 'await' operator to await non-blocking API calls, or 'await Task.Run(...)' to do CPU-bound work on a background thread.
        public async Task<IViewComponentResult> InvokeAsync(int categoryId)
#pragma warning restore CS1998 // This async method lacks 'await' operators and will run synchronously. Consider using the 'await' operator to await non-blocking API calls, or 'await Task.Run(...)' to do CPU-bound work on a background thread.
        {
            var path = HttpContext.Request.Path.ToString();
            string[] split = path.Split("/");
            if (path.Contains("ana-kategori"))
            {
                ViewBag.CategoryName = _db.Categories.FirstOrDefault(x => x.CategoryId == Convert.ToInt32(split[4])).CategoryName;
            }
            if (path.Contains("alt-kategori"))
            {
                ViewBag.CategoryName = _db.SubCategories.FirstOrDefault(x => x.CategoryId == Convert.ToInt32(split[4]) && x.SubCategoryId == Convert.ToInt32(split[5])).SubCategoryName;
            }
            ViewBag.selectedCategory = categoryId;
            return View();
        }
    }
}