using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using WebDooreme.Models;

namespace WebDooreme.Controllers
{
    [Authorize]
    public class ReferansTablesController : Controller
    {
        private readonly sifatakiContext _context;

        public ReferansTablesController(sifatakiContext context)
        {
            _context = context;
        }

        // GET: ReferansTables
        public async Task<IActionResult> Index()
        {
            return View(await _context.ReferansTables.ToListAsync());
        }

        // GET: ReferansTables/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var referansTable = await _context.ReferansTables
                .FirstOrDefaultAsync(m => m.Id == id);
            if (referansTable == null)
            {
                return NotFound();
            }

            return View(referansTable);
        }

        // GET: ReferansTables/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ReferansTables/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Company,Province,District")] ReferansTable referansTable)
        {
            if (ModelState.IsValid)
            {
                _context.Add(referansTable);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(referansTable);
        }

        // GET: ReferansTables/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var referansTable = await _context.ReferansTables.FindAsync(id);
            if (referansTable == null)
            {
                return NotFound();
            }
            return View(referansTable);
        }

        // POST: ReferansTables/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Company,Province,District")] ReferansTable referansTable)
        {
            if (id != referansTable.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(referansTable);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReferansTableExists(referansTable.Id))
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
            return View(referansTable);
        }

        // GET: ReferansTables/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var referansTable = await _context.ReferansTables
                .FirstOrDefaultAsync(m => m.Id == id);
            if (referansTable == null)
            {
                return NotFound();
            }

            return View(referansTable);
        }

        // POST: ReferansTables/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var referansTable = await _context.ReferansTables.FindAsync(id);
            _context.ReferansTables.Remove(referansTable);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReferansTableExists(int id)
        {
            return _context.ReferansTables.Any(e => e.Id == id);
        }
    }
}
