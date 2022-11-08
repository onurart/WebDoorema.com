using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using WebDooreme.Models;
namespace WebDooreme.Components
{
    public class ProductDetail : ViewComponent
    {
        private readonly sifatakiContext _db;
        public ProductDetail(sifatakiContext db)
        {
            _db = db;
        }
        public async Task<IViewComponentResult> InvokeAsync(string stockCode)
        {
            //var cleanCode=
            var door = await _db.Products.FirstOrDefaultAsync(m => m.StockCode == stockCode);
           
            return View(door);
        }
    }
}