using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using WebDooreme.Models;
namespace WebDooreme.Controllers
{
    public class ProductController : Controller
    {
        private readonly sifatakiContext _db;
        public ProductController(sifatakiContext db)
        {
            _db = db;
        }
        public IActionResult Index(int categoryId, int subCategoryId)
        {
            var productlist = _db.Products.ToList();
            ViewBag.selectedCategory = categoryId;
            ViewBag.selectedSubCategory = subCategoryId;
            return View(productlist);
        }
        public IActionResult ProductToCategory(int categoryId)
        {
            var category = _db.Categories.FirstOrDefault(x => x.CategoryId == categoryId);
            ViewBag.title = category.MetaTitle;
            ViewBag.description = category.MetaDesc;
            ViewBag.keywords = category.MetaKeywords;
            ViewBag.selectedCategory = categoryId;
            if (category.CategoryId == 8)
            {
                var productList = _db.Products.OrderBy(x => x.DisplayOrder).Where(m => m.CategoryId == categoryId).ToList();
                return View(productList);
            }
            if (category.CategoryId == 10)
            {
                var productList = _db.Products.OrderBy(x => x.DisplayOrder).Where(m => m.CategoryId == categoryId).ToList();
                return View(productList);
            }
            if (category.CategoryId == 16)
            {
                var productList = _db.Products.OrderBy(x => x.DisplayOrder).Where(m => m.CategoryId == categoryId).ToList();
                return View(productList);


            }
            else
            {
                var productList = _db.Products.OrderByDescending(x => x.DisplayOrder).Where(m => m.CategoryId == categoryId).ToList();

                return View(productList);
            }

        }
        public IActionResult ProductToSubCategory(int categoryId, int subCategoryId)
        {
            var category = _db.SubCategories.FirstOrDefault(x => x.CategoryId == categoryId && x.SubCategoryId == subCategoryId);
            ViewBag.title = category.MetaTitle;
            ViewBag.description = category.MetaDesc;
            ViewBag.keywords = category.MetaKeywords;
            ViewBag.selectedCategory = categoryId;
            ViewBag.selectedSubCategory = subCategoryId;
            var productList = _db.Products.OrderByDescending(x => x.DisplayOrder).Where(m => m.CategoryId == categoryId && m.SubCategoryId == subCategoryId).ToList();
            return View(productList);
        }
        [HttpGet]
        public async Task<IActionResult> Details(string stockCode, int categoryId, int subCategoryId, int relatedCategory)
        {
            ProductDetailsViewModel productDetailsViewModel = new ProductDetailsViewModel();
            ViewBag.selectedCategory = categoryId;
            ViewBag.selectedSubCategory = subCategoryId;
            ViewBag.relatedCategory = relatedCategory;
            if (string.IsNullOrEmpty(stockCode))
            {

                return NotFound();
            }
            var product = await _db.Products.FirstOrDefaultAsync(m => m.StockCode == stockCode);
            if (product == null)
            {
                return NotFound();
            }
            productDetailsViewModel.Product = product;
            return View(productDetailsViewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Details(ProductDetailsViewModel model)
        {
            ProductDetailsViewModel productDetailsViewModel = new ProductDetailsViewModel();
            if (string.IsNullOrEmpty(model.StockCode))
            {
                return NotFound();
            }
            var product = await _db.Products.FirstOrDefaultAsync(m => m.StockCode == model.StockCode);
            if (product == null)
                return NotFound();
            else
            {
                productDetailsViewModel.Product = product;
                productDetailsViewModel.FullName = model.FullName;
                productDetailsViewModel.Address = model.Address;
                productDetailsViewModel.Email = model.Email;
                productDetailsViewModel.Phone = model.Phone;
                productDetailsViewModel.ProductName = model.ProductName;
                productDetailsViewModel.StockCode = model.StockCode;
            }
            if (ModelState.IsValid)
            {
                var body = new StringBuilder();
                body.AppendLine("Ürün Adı: " + model.ProductName + "<br>");
                body.AppendLine("Adınız: " + model.FullName + "<br>");
                body.AppendLine("Telefon: " + model.Phone + "<br>");
                body.AppendLine("E-mail: " + model.Email + "<br>");
                body.AppendLine("Mesaj: " + model.Address + "<br>");
                if (await SendEmail(body.ToString()))
                {
                    ViewBag.IsSendMail = "Email gönderildi!";
                }
                else
                {
                    ViewBag.IsSendMail = "Email gönderilemedi!";
                }
                ViewBag.Success = true;
                ViewBag.title = product.ProductName + " | doorema.com.tr";
                ViewBag.description = product.Description;
                ViewBag.keywords = product.Keywords;
            }
            return View(productDetailsViewModel);
        }
        public async Task<bool> SendEmail(string emailMessage)
        {
#pragma warning disable CS0168 // The variable 'ex' is declared but never used
            try
            {
                string email = "ema@emacelikkapi.com";
                var message = new MailMessage();
                var fromAddress = new MailAddress(email, "Ürün Detay");//adresten
                var toAddress = new MailAddress("ema@emacelikkapi.com");//adrese
                const string subject = "Ürün Ön Bilgi ve Talep Formu";
                message.To.Add(toAddress);
                message.From = fromAddress;
                message.Subject = subject;
                message.Body = emailMessage;
                message.IsBodyHtml = true;
                using var smtpClient = new SmtpClient
                {
                    Host = "mail.emacelikkapi.com",
                    Port = 587,
                    EnableSsl = false,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, "789456em"),
                };
                await smtpClient.SendMailAsync(message);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
#pragma warning restore CS0168 // The variable 'ex' is declared but never used
        }
    }
}