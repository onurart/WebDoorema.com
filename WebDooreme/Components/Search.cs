using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using WebDooreme.Models;
namespace WebDooreme.Components
{
    public class Search : ViewComponent
    {
        private readonly sifatakiContext _db;
        public Search(sifatakiContext db)
        {
            _db = db;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var cate = await _db.Categories.ToListAsync();
            return View(cate);
        }
    }
}