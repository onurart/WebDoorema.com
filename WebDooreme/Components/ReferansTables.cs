using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using WebDooreme.Models;

namespace WebDooreme.Components
{
    public class ReferansTables :ViewComponent
    {
        private readonly sifatakiContext _db;
        public ReferansTables(sifatakiContext db)
        {
            _db = db;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var refs =  await _db.ReferansTables.ToListAsync();
            return View(refs);
        }
    }
}
