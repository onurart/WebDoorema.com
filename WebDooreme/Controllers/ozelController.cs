using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using WebDooreme.Models;
namespace WebDooreme.Controllers
{
    public class ozelController : Controller
    {
        private readonly sifatakiContext _context;
        public ozelController(sifatakiContext context)
        {
            _context = context;
        }
        // GET: ozel
        public async Task<IActionResult> Index()
        {
            var sifatakiContext = _context.Products.Include(p => p.Category).Include(p => p.SubCategoryClass);
            return View(await sifatakiContext.ToListAsync());
        }
        // GET: ozel/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var product = await _context.Products
                .Include(p => p.Category)
                .Include(p => p.SubCategoryClass)
                .FirstOrDefaultAsync(m => m.ProductId == id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }
        // GET: ozel/Create
        public IActionResult Create()
        {
            ViewData["CategoryId"] = new SelectList(_context.Categories, "CategoryId", "CategoryId");
            ViewData["SubCategoryClassId"] = new SelectList(_context.SubCategoryClasses, "SubCategoryClassId", "SubCategoryClassId");
            return View();
        }
        // POST: ozel/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProductId,CategoryId,SubCategoryId,SubCategoryClassId,ItemName,StockCode,StockUnit,ProductName,Mark,Keywords,Description,InstallmentTable,Price,DiscountPrice,DiscountPrice2,DiscountPrice3,RelegatePrice,CargoPrice,LastPrice,CargoDiamension,Image,ImageDetails,Thumbnail1,Thumbnail2,Thumbnail3,Tax,ProductDetail,ProductWords,Campaign,NewProduct,PopulateProduct,DiscountProduct,SpecialProduct,MainPageProduct,RecomandedProduct,ViewCase")] Product product)
        {
            if (ModelState.IsValid)
            {
                _context.Add(product);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories, "CategoryId", "CategoryId", product.CategoryId);
            ViewData["SubCategoryClassId"] = new SelectList(_context.SubCategoryClasses, "SubCategoryClassId", "SubCategoryClassId", product.SubCategoryClassId);
            return View(product);
        }
        // GET: ozel/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories, "CategoryId", "CategoryId", product.CategoryId);
            ViewData["SubCategoryClassId"] = new SelectList(_context.SubCategoryClasses, "SubCategoryClassId", "SubCategoryClassId", product.SubCategoryClassId);
            return View(product);
        }
        // POST: ozel/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProductId,CategoryId,SubCategoryId,SubCategoryClassId,ItemName,StockCode,StockUnit,ProductName,Mark,Keywords,Description,InstallmentTable,Price,DiscountPrice,DiscountPrice2,DiscountPrice3,RelegatePrice,CargoPrice,LastPrice,CargoDiamension,Image,ImageDetails,Thumbnail1,Thumbnail2,Thumbnail3,Tax,ProductDetail,ProductWords,Campaign,NewProduct,PopulateProduct,DiscountProduct,SpecialProduct,MainPageProduct,RecomandedProduct,ViewCase")] Product product)
        {
            if (id != product.ProductId)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(product);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(product.ProductId))
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
            ViewData["CategoryId"] = new SelectList(_context.Categories, "CategoryId", "CategoryId", product.CategoryId);
            ViewData["SubCategoryClassId"] = new SelectList(_context.SubCategoryClasses, "SubCategoryClassId", "SubCategoryClassId", product.SubCategoryClassId);
            return View(product);
        }
        // GET: ozel/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var product = await _context.Products
                .Include(p => p.Category)
                .Include(p => p.SubCategoryClass)
                .FirstOrDefaultAsync(m => m.ProductId == id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }
        // POST: ozel/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var product = await _context.Products.FindAsync(id);
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        private bool ProductExists(int id)
        {
            return _context.Products.Any(e => e.ProductId == id);
        }
    }
}