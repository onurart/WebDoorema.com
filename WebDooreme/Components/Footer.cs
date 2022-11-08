using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using WebDooreme.Models;
namespace WebDooreme.Components
{
    public class Footer : ViewComponent
    {
        private readonly sifatakiContext _db;
        public Footer(sifatakiContext db)
        {
            _db = db;
        }
#pragma warning disable CS1998 // This async method lacks 'await' operators and will run synchronously. Consider using the 'await' operator to await non-blocking API calls, or 'await Task.Run(...)' to do CPU-bound work on a background thread.
        public async Task<IViewComponentResult> InvokeAsync()
#pragma warning restore CS1998 // This async method lacks 'await' operators and will run synchronously. Consider using the 'await' operator to await non-blocking API calls, or 'await Task.Run(...)' to do CPU-bound work on a background thread.
        {
            var footer = _db.Categories.ToList();
            return View(footer);
        }
    }
}