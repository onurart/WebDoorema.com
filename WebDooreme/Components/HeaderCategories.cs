using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using WebDooreme.Models;
namespace WebDooreme.Components
{
    public class HeaderCategories : ViewComponent
    {
        private readonly sifatakiContext _db;
        public HeaderCategories(sifatakiContext db)
        {
            _db = db;
        }
        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            var cate = await _db.Categories.OrderBy(x=>x.DisplayOrder).ToListAsync();
            var pro = await _db.SubCategories.ToListAsync();
            var productViewModel = new MenuCategoiesViewModel
            {
                Categories = cate,
                Sub = pro,
            };
            return View(productViewModel);
        }
    }
}