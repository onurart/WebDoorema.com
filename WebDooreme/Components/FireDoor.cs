using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using WebDooreme.Models;
namespace WebDooreme.Components
{
    public class FireDoor : ViewComponent
    {
        private readonly sifatakiContext _db;
        public FireDoor(sifatakiContext db)
        {
            _db = db;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(await _db.Products.OrderBy(s=>s.DisplayOrder).Where(x => x.CategoryId.Equals(16)).ToListAsync());
        }
    }
}