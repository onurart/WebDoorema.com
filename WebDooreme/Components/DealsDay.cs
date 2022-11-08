using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using WebDooreme.Models;
namespace WebDooreme.Components
{
    public class DealsDay : ViewComponent
    {
        private readonly sifatakiContext _db;
        public DealsDay(sifatakiContext db)
        {
            _db = db;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var dealsDayProduct = await _db.Products.Where(ax => ax.CategoryId.Equals(8)).Skip(0).Take(50).ToListAsync();
            return View(dealsDayProduct);
        }
    }
}