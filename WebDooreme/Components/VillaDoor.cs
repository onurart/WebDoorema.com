using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using WebDooreme.Models;
namespace WebDooreme.Components
{
    public class VillaDoor : ViewComponent
    {
        private readonly sifatakiContext _db;
        public VillaDoor(sifatakiContext db)
        {
            _db = db;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var mystellDoor = await _db.Products.OrderBy(x=>x.DisplayOrder).Where(s => s.CategoryId.Equals(10)).ToListAsync();
            return View(mystellDoor);
        }
    }
}