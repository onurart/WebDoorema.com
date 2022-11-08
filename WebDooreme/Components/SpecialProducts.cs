using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using WebDooreme.Models;
namespace WebDooreme.Components
{
    public class SpecialProducts : ViewComponent
    {
        private readonly sifatakiContext _db;
        public SpecialProducts(sifatakiContext db)
        {
            _db = db;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var specialProduct = await _db.Products.Where(ax => ax.CategoryId.Equals(8)).ToListAsync();
            var test = specialProduct.OrderByDescending(x => x.ProductId).ToList();
            return View(test);
        }
    }
}