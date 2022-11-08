using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using WebDooreme.Models;
namespace WebDooreme.Components
{
    public class Slider : ViewComponent
    {
        private readonly sifatakiContext _db;
        public Slider(sifatakiContext db)
        {
            _db = db;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var sliderList = await _db.Sliders.ToListAsync();
            return View(sliderList);
        }
    }
}