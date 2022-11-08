using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using WebDooreme.Helpers;
using WebDooreme.Models;
namespace WebDooreme.Controllers
{
    [Authorize]
    public class AdminBlogsController : Controller
    {
        private readonly sifatakiContext _context;
        public AdminBlogsController(sifatakiContext context)
        {
            _context = context;
        }
        // GET: AdminBlogs
        public async Task<IActionResult> Index()
        {
            return View(await _context.Blogs.OrderByDescending(x => x.Id).ToListAsync());
        }
        // GET: AdminBlogs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var blog = await _context.Blogs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (blog == null)
            {
                return NotFound();
            }
            return View(blog);
        }
        // GET: AdminBlogs/Create
        public IActionResult Create()
        {
            return View();
        }
        // POST: AdminBlogs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Blog blog)
        {
            if (ModelState.IsValid)
            {
                blog.ImageUrl = await ImageHelper.GetUploadImageName(blog.ImageFile, ImagePaths.Upload);
                blog.CreateDate = DateTime.Now;
                _context.Add(blog);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(blog);
        }
        // GET: AdminBlogs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var blog = await _context.Blogs.FindAsync(id);
            if (blog == null)
            {
                return NotFound();
            }
            return View(blog);
        }
        // POST: AdminBlogs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Blog blog)
        {
            if (id != blog.Id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    if (blog.ImageFile != null)
                        blog.ImageUrl = await ImageHelper.GetUploadImageName(blog.ImageFile, ImagePaths.Upload);
                    _context.Update(blog);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BlogExists(blog.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(blog);
        }
        // GET: AdminBlogs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var blog = await _context.Blogs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (blog == null)
            {
                return NotFound();
            }
            return View(blog);
        }
        // POST: AdminBlogs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var blog = await _context.Blogs.FindAsync(id);
            _context.Blogs.Remove(blog);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        private bool BlogExists(int id)
        {
            return _context.Blogs.Any(e => e.Id == id);
        }
    }
}