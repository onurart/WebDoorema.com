using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using WebDooreme.Models;
namespace WebDooreme.Components
{
    public class ProjeDoor : ViewComponent
    {
        private readonly sifatakiContext _db;
        public ProjeDoor(sifatakiContext db)
        {
            _db = db;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var projeDoor = await _db.Products.Where(s => s.CategoryId.Equals(8)).OrderBy(x => x.DisplayOrder).ToListAsync();
            var pDoor = projeDoor;
            return View(pDoor);
        }
    }
}