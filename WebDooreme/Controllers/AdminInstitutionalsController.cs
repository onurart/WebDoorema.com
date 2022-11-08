using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using WebDooreme.Models;
namespace WebDooreme.Controllers
{
    [Authorize]
    public class AdminInstitutionalsController : Controller
    {
        private readonly sifatakiContext _context;
        public AdminInstitutionalsController(sifatakiContext context)
        {
            _context = context;
        }
        // GET: AdminInstitutionals
        public async Task<IActionResult> Index()
        {
            return View(await _context.Institutionals.ToListAsync());
        }
        // GET: AdminInstitutionals/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var institutional = await _context.Institutionals
                .FirstOrDefaultAsync(m => m.Id == id);
            if (institutional == null)
            {
                return NotFound();
            }
            return View(institutional);
        }
        // GET: AdminInstitutionals/Create
        public IActionResult Create()
        {
            return View();
        }
        // POST: AdminInstitutionals/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Tİtle,İmages,Açıklama")] Institutional institutional)
        {
            if (ModelState.IsValid)
            {
                _context.Add(institutional);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(institutional);
        }
        // GET: AdminInstitutionals/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var institutional = await _context.Institutionals.FindAsync(id);
            if (institutional == null)
            {
                return NotFound();
            }
            return View(institutional);
        }
        // POST: AdminInstitutionals/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Tİtle,İmages,Açıklama")] Institutional institutional)
        {
            if (id != institutional.Id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(institutional);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InstitutionalExists(institutional.Id))
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
            return View(institutional);
        }
        // GET: AdminInstitutionals/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var institutional = await _context.Institutionals
                .FirstOrDefaultAsync(m => m.Id == id);
            if (institutional == null)
            {
                return NotFound();
            }
            return View(institutional);
        }
        // POST: AdminInstitutionals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var institutional = await _context.Institutionals.FindAsync(id);
            _context.Institutionals.Remove(institutional);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        private bool InstitutionalExists(int id)
        {
            return _context.Institutionals.Any(e => e.Id == id);
        }
    }
}