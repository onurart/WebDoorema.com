using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using WebDooreme.Models;
namespace WebDooreme.Controllers
{
    [Authorize]
    public class AdminTechnicalsController : Controller
    {
        private readonly sifatakiContext _context;
        public AdminTechnicalsController(sifatakiContext context)
        {
            _context = context;
        }
        // GET: AdminTechnicals
        public async Task<IActionResult> Index()
        {
            return View(await _context.Technicals.ToListAsync());
        }
        // GET: AdminTechnicals/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var technical = await _context.Technicals
                .FirstOrDefaultAsync(m => m.Id == id);
            if (technical == null)
            {
                return NotFound();
            }
            return View(technical);
        }
        // GET: AdminTechnicals/Create
        public IActionResult Create()
        {
            return View();
        }
        // POST: AdminTechnicals/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Tİtle,Aciklama,Title2,Acıklama2,İmages,Aİmages,Images2,Aimages2,Images3,Aimages3,Images4,Aimages4")] Technical technical)
        {
            if (ModelState.IsValid)
            {
                _context.Add(technical);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(technical);
        }
        // GET: AdminTechnicals/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var technical = await _context.Technicals.FindAsync(id);
            if (technical == null)
            {
                return NotFound();
            }
            return View(technical);
        }
        // POST: AdminTechnicals/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Tİtle,Aciklama,Title2,Acıklama2,İmages,Aİmages,Images2,Aimages2,Images3,Aimages3,Images4,Aimages4")] Technical technical)
        {
            if (id != technical.Id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(technical);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TechnicalExists(technical.Id))
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
            return View(technical);
        }
        // GET: AdminTechnicals/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var technical = await _context.Technicals
                .FirstOrDefaultAsync(m => m.Id == id);
            if (technical == null)
            {
                return NotFound();
            }
            return View(technical);
        }
        // POST: AdminTechnicals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var technical = await _context.Technicals.FindAsync(id);
            _context.Technicals.Remove(technical);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        private bool TechnicalExists(int id)
        {
            return _context.Technicals.Any(e => e.Id == id);
        }
    }
}