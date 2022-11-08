using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using WebDooreme.Models;

namespace WebDooreme.Components
{
    public class RelatedProduct : ViewComponent
    {
        private readonly sifatakiContext _db;
        public RelatedProduct(sifatakiContext db)
        {
            _db = db;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var ex = await _db.Products.ToListAsync();
          

            return View(ex);
        }
    }
}