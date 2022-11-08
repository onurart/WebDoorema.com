using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using WebDooreme.Models;
using System.Linq;
namespace WebDooreme.Components
{
    public class SteelDoor : ViewComponent
    {
        private readonly sifatakiContext _db;
        public SteelDoor(sifatakiContext db)
        {
            _db = db;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            //var cleanCode=
            var mystellDoor = await _db.Products.OrderByDescending(x=>x.StockCode).ToListAsync();
            return View(mystellDoor);
        }
    }
}