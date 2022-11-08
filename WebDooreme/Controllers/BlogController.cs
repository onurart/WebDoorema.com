using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using WebDooreme.Models;
namespace WebDooreme.Controllers
{
    public class BlogController : Controller
    {
        private readonly sifatakiContext _db;
        public BlogController(sifatakiContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var blogs = _db.Blogs.ToList();
            return View(blogs);
        }
        public async Task<IActionResult> Details(int id)
        {
            var blogs = await _db.Blogs.FirstOrDefaultAsync(m => m.Id == id);
            if (blogs == null)
            {
                return NotFound();
            }
            return View(blogs);
        }
    }
}