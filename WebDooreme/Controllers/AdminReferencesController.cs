using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using WebDooreme.Models;
namespace WebDooreme.Controllers
{
    [Authorize]
    public class AdminReferencesController : Controller
    {
        private readonly sifatakiContext _context;
        public AdminReferencesController(sifatakiContext context)
        {
            _context = context;
        }
        // GET: AdminReferences
        public async Task<IActionResult> Index()
        {
            return View(await _context.Reference.ToListAsync());
        }
        // GET: AdminReferences/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var reference = await _context.Reference
                .FirstOrDefaultAsync(m => m.ReferenceId == id);
            if (reference == null)
            {
                return NotFound();
            }
            return View(reference);
        }
        // GET: AdminReferences/Create
        public IActionResult Create()
        {
            return View();
        }
        // POST: AdminReferences/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ReferenceId,ReferenceName,ReferenceType,ReferenceImage,ReferenceThumb1,ReferenceThumb2,ReferenceThumb3,ReferenceThumb4")] Reference reference)
        {
            if (ModelState.IsValid)
            {
                _context.Add(reference);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(reference);
        }
        // GET: AdminReferences/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
#pragma warning disable CS0168 // The variable 'ex' is declared but never used
            try
            {
#pragma warning disable CS0472 // The result of the expression is always 'false' since a value of type 'int' is never equal to 'null' of type 'int?'
                if (id == null)
                {
                    return NotFound();
                }
#pragma warning restore CS0472 // The result of the expression is always 'false' since a value of type 'int' is never equal to 'null' of type 'int?'
                var reference = await _context.Reference.FindAsync(id);
                if (reference == null)
                {
                    return NotFound();
                }
                return View(reference);

            }
            catch (System.Exception ex)
            {

                throw;
            }
#pragma warning restore CS0168 // The variable 'ex' is declared but never used
          
        }
        // POST: AdminReferences/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ReferenceId,ReferenceName,ReferenceType,ReferenceImage,ReferenceThumb1,ReferenceThumb2,ReferenceThumb3,ReferenceThumb4")] Reference reference)
        {
            if (id != reference.ReferenceId)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(reference);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReferenceExists(reference.ReferenceId))
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
            return View(reference);
        }
        // GET: AdminReferences/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var reference = await _context.Reference
                .FirstOrDefaultAsync(m => m.ReferenceId == id);
            if (reference == null)
            {
                return NotFound();
            }
            return View(reference);
        }
        // POST: AdminReferences/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var reference = await _context.Reference.FindAsync(id);
            _context.Reference.Remove(reference);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        private bool ReferenceExists(int id)
        {
            return _context.Reference.Any(e => e.ReferenceId == id);
        }
    }
}