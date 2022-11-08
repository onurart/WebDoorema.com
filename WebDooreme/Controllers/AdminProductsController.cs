using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebDooreme.Models;
namespace WebDooreme.Controllers
{
    [Authorize]
    public class AdminProductsController : Controller
    {
        private readonly sifatakiContext _context;
        public AdminProductsController(sifatakiContext context)
        {
            _context = context;
        }
        // GET: AdminProducts
        public async Task<IActionResult> Index()
        {
            //var products = from product in _context.Products
            //               join mainCategory in _context.Categories on product.CategoryId equals mainCategory.CategoryId
            //               join subCategory in _context.SubCategories on product.SubCategoryId equals subCategory.SubCategoryId
            //               select new ProductViewModel()
            //               {
            //                   Description = product.Description,
            //                   Image = product.Image,
            //                   MainCategoryName = mainCategory.CategoryName,
            //                   ProductId = product.ProductId,
            //                   ProductName = product.ProductName,
            //                   StockCode = product.StockCode,
            //                   SubCategoryName = subCategory.SubCategoryName,
            //               };
            var products = _context.Products.Include(p => p.Category).Include(p => p.SubCategoryClass);
            return View(await products.ToListAsync());
        }
        // GET: AdminProducts/Details/5
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
        // GET: AdminProducts/Create
        public IActionResult Create()
        {
            ViewData["CategoryId"] = new SelectList(_context.Categories, "CategoryName", "CategoryName");
            ViewData["SubCategoryClassId"] = new SelectList(_context.SubCategories, "SubCategoryName", "SubCategoryName");
            return View();
        }
        // POST: AdminProducts/Create
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
        // GET: AdminProducts/Edit/5
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
        // POST: AdminProducts/Edit/5
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
        // GET: AdminProducts/Delete/5
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
        // POST: AdminProducts/Delete/5
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