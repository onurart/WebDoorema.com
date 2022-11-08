        using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WebDooreme.Models;
namespace WebDooreme.Controllers
{
    [Authorize]
    public class AdminDocumentsController : Controller
    {
        private readonly sifatakiContext _context;
        private readonly IWebHostEnvironment _env;
        public AdminDocumentsController(sifatakiContext context, IWebHostEnvironment hostingEnvironment)
        {
            _context = context;
            _env = hostingEnvironment;
        }
        // GET: AdminDocuments
        public async Task<IActionResult> Index()
        {
            return View(await _context.Documents.ToListAsync());
        }
        [HttpPost]
        public IActionResult UploadFile()
        {
            foreach (var formFile in Request.Form.Files)
            {
                var fulPath = Path.Combine(_env.ContentRootPath, "wwwroot\\files", formFile.FileName);
                using (FileStream fs = System.IO.File.Create(fulPath))
                {
                    formFile.CopyTo(fs);
                    fs.Flush();
                }
                return Json("Upload image succesfully.");
            }
            return Json("Please Try Again !!");
        }
        // GET: AdminDocuments/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var document = await _context.Documents
                .FirstOrDefaultAsync(m => m.Id == id);
            if (document == null)
            {
                return NotFound();
            }
            return View(document);
        }
        // GET: AdminDocuments/Create
        public IActionResult Create()
        {
            return View();
        }
        // POST: AdminDocuments/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Images")] Document document)
        {
            if (ModelState.IsValid)
            {
                _context.Add(document);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(document);
        }
        //[HttpPost]
        //public async Task<IActionResult> DocumentImageUpload(List<IFormFile> files)
        //{
        //    long size = files.Sum(f => f.Length);
        //    string fileNames = "";
        //    foreach (var formFile in files)
        //    {
        //        if (formFile.Length > 0)
        //        {
        //            var filePath = _hostingEnvironment.WebRootPath + "\\images\\AdminDocuments\\" + Path.GetTempFileName();
        //            if (string.IsNullOrEmpty(fileNames))
        //                fileNames = Path.GetTempFileName();
        //            else
        //                fileNames = fileNames + ";" + Path.GetTempFileName();
        //            using var stream = System.IO.File.Create(filePath);
        //            await formFile.CopyToAsync(stream);
        //        }
        //    }
        //    // Process uploaded files
        //    // Don't rely on or trust the FileName property without validation.
        //    return Ok(new { count = files.Count, size, files = fileNames });
        //}
        //[HttpPost]
        //public async Task<IActionResult> DocumentImageUpload(IList<IFormFile> files)
        //{
        //    foreach (IFormFile source in files)
        //    {
        //        string filename = ContentDispositionHeaderValue.Parse(source.ContentDisposition).FileName.Trim('"');
        //        filename = this.EnsureCorrectFilename(filename);
        //        using (FileStream output = System.IO.File.Create(this.GetPathAndFilename(filename)))
        //            await source.CopyToAsync(output);
        //    }
        //    return this.View();
        //}
        private string EnsureCorrectFilename(string filename)
        {
            if (filename.Contains("\\"))
                filename = filename.Substring(filename.LastIndexOf("\\") + 1);
            return filename;
        }
        //private string GetPathAndFilename(string filename)
        //{
        //    return _hostingEnvironment.WebRootPath + "\\uploads\\" + filename;
        //}
        // GET: AdminDocuments/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var document = await _context.Documents.FindAsync(id);
            if (document == null)
            {
                return NotFound();
            }
            return View(document);
        }
        // POST: AdminDocuments/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Images")] Document document)
        {
            if (id != document.Id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(document);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DocumentExists(document.Id))
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
            return View(document);
        }
        // GET: AdminDocuments/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var document = await _context.Documents
                .FirstOrDefaultAsync(m => m.Id == id);
            if (document == null)
            {
                return NotFound();
            }
            return View(document);
        }
        // POST: AdminDocuments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var document = await _context.Documents.FindAsync(id);
            _context.Documents.Remove(document);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        private bool DocumentExists(int id)
        {
            return _context.Documents.Any(e => e.Id == id);
        }
    }
}