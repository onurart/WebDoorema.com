using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using WebDooreme.Models;

namespace WebDooreme.Components
{
    public class Campaign : ViewComponent
    {
        private readonly sifatakiContext _context;
        public Campaign(sifatakiContext sifatakiContext)
        {
            _context = sifatakiContext;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            //var products = await _context.Products.Where(x => x.CategoryId == 1).Where(x=>x.DiscountProduct==true).OrderBy(x => x.DisplayOrder).ToListAsync();

            var products = await _context.Products.Where(x => x.DiscountProduct == true).OrderBy(x => x.DisplayOrder).ToListAsync();
            return View(products);
            //return View(products);
        }
    }
}