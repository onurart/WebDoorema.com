using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using WebDooreme.Models;
namespace WebDooreme.Components
{
    public class LastBlogCategories : ViewComponent
    {
        private readonly sifatakiContext _db;
        public LastBlogCategories(sifatakiContext db)
        {
            _db = db;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var blog = await _db.Blogs.Skip(0).Take(50).OrderByDescending(x => x.Id).ToListAsync();
            return View(blog);
        }
    }
}