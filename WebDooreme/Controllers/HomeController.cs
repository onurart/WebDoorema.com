using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using WebDooreme.Helpers;
using WebDooreme.Models;
namespace WebDooreme.Controllers
{
    public class HomeController : Controller
    {
        private readonly sifatakiContext _db;
        private readonly ILogger<HomeController> _logger;
        private readonly IWebHostEnvironment _env;
        public HomeController(ILogger<HomeController> logger, sifatakiContext db, IWebHostEnvironment env)
        {
            _logger = logger;
            _db = db;
            _env = env;
        }
        public class SitemapViewModel
        {
            public string Loc { get; set; }
            public string Priority { get; set; }
            public string ChangeFreq { get; set; }
            public string LastModified { get; set; }
        }
        [Route("/sitemap.xml")]
#pragma warning disable CS1998 // This async method lacks 'await' operators and will run synchronously. Consider using the 'await' operator to await non-blocking API calls, or 'await Task.Run(...)' to do CPU-bound work on a background thread.
        public async void SitemapXml()
#pragma warning restore CS1998 // This async method lacks 'await' operators and will run synchronously. Consider using the 'await' operator to await non-blocking API calls, or 'await Task.Run(...)' to do CPU-bound work on a background thread.
        {
            string host = "";
            var data = new List<SitemapViewModel>();
            data.Add(new SitemapViewModel { Loc = "/anasayfa", LastModified = DateTime.Now.ToString("yyyy-MM-dd") });
            data.Add(new SitemapViewModel { Loc = "/kurumsal", LastModified = DateTime.Now.ToString("yyyy-MM-dd") });
            data.Add(new SitemapViewModel { Loc = "/teknik-bilgi", LastModified = DateTime.Now.ToString("yyyy-MM-dd") });
            data.Add(new SitemapViewModel { Loc = "/proje-yonetimi", LastModified = DateTime.Now.ToString("yyyy-MM-dd") });
            data.Add(new SitemapViewModel { Loc = "/referanslar", LastModified = DateTime.Now.ToString("yyyy-MM-dd") });
            data.Add(new SitemapViewModel { Loc = "/belgeler", LastModified = DateTime.Now.ToString("yyyy-MM-dd") });
            data.Add(new SitemapViewModel { Loc = "/blog", LastModified = DateTime.Now.ToString("yyyy-MM-dd") });
            data.Add(new SitemapViewModel { Loc = "/iletişim", LastModified = DateTime.Now.ToString("yyyy-MM-dd") });
            data.Add(new SitemapViewModel { Loc = "/soru-cevap", LastModified = DateTime.Now.ToString("yyyy-MM-dd") });
            try
            {
                foreach (var itemBlog in _db.Blogs.ToList())
                {
                    //blog/detay/{title}/{id}
                    data.Add(new SitemapViewModel()
                    {
                        Loc = "/blog/detay/" + UrlExtension.FriendlyUrl(Url, itemBlog.Title) + "/" + itemBlog.Id,
                        LastModified = DateTime.Now.ToString("yyyy-MM-dd"),
                    });
                }
                foreach (var itemCategory in _db.Categories.ToList())
                {
                    //urun/ana-kategori/{title}/{categoryId}
                    data.Add(new SitemapViewModel()
                    {
                        Loc = "/urun/ana-kategori/" + UrlExtension.FriendlyUrl(Url, itemCategory.CategoryName) + "/" + itemCategory.CategoryId,
                        LastModified = DateTime.Now.ToString("yyyy-MM-dd"),
                    });
                }
                foreach (var itemSubCategory in _db.SubCategories.ToList())
                {
                    //urun/alt-kategori/{title}/{categoryId}/{subCategoryId}
                    data.Add(new SitemapViewModel()
                    {
                        Loc = "/urun/alt-kategori/" + UrlExtension.FriendlyUrl(Url, itemSubCategory.SubCategoryName) + "/" + itemSubCategory.CategoryId + "/" + itemSubCategory.SubCategoryId,
                        LastModified = DateTime.Now.ToString("yyyy-MM-dd"),
                    });
                }
                foreach (var itemProduct in _db.Products.ToList())
                {
                    //urun/detay/{title}/{stockCode}
                    data.Add(new SitemapViewModel()
                    {
                        Loc = "/urun/detay/" + UrlExtension.FriendlyUrl(Url, itemProduct.ProductName) + "/" + itemProduct.StockCode,
                        LastModified = DateTime.Now.ToString("yyyy-MM-dd"),
                    });
                }
                CreateXml(host, data);
            }
            catch (Exception)
            {
                CreateXml(host, data);
            }
        }
        private void CreateXml(string host, List<SitemapViewModel> data)
        {
            host = Request.Scheme + "://" + Request.Host;
            Response.ContentType = "application/xml";
            using (var xml = XmlWriter.Create(Response.Body, new XmlWriterSettings { Indent = true }))
            {
                xml.WriteStartDocument();
                xml.WriteStartElement("urlset", "http://www.sitemaps.org/schemas/sitemap/0.9");
                foreach (var item in data)
                {
                    xml.WriteStartElement("url");
                    xml.WriteElementString("loc", host + item.Loc);
                    //xml.WriteElementString("priority", item.Priority);
                    //xml.WriteElementString("changefreq", item.ChangeFreq);
                    xml.WriteElementString("lastmod", item.LastModified);
                    xml.WriteEndElement();
                }
                xml.WriteEndElement();
            }
        }
        public IActionResult Index()
        {
            ViewBag.title = "Ana Sayfa | doorema.com.tr";
            ViewBag.description = "Doorema proje, Çelik kapıları,  Klasik ve Modern Çelik Kapılar, Villa ve Bina Giriş Kapıları, çelik ve paslanmaz çelik kapılar, eşgörünümlü, zarif görünümüyle göze çarpmaktadır ve aynı kapı görünümüyle birbirleriyle mükemmel uyum sağlamaktadır iş yerinize ve dilediğiniz alana";
            ViewBag.keywords = "anasayfa,doorema,çelik kapı,yangın kapıları";
            return View();
        }
        public IActionResult Institutional()
        {
            ViewBag.title = "Kurumsal | doorema.com.tr";
            ViewBag.description = "Doorema  Kurumsal";
            ViewBag.keywords = "kurumsal,doorema,çelik kapı,yangın kapıları";
            var inst = _db.Institutionals.ToList();
            return View(inst);
        }
        public IActionResult faq()
        {
            ViewBag.title = "Soru ve Cevap | doorema.com.tr";
            ViewBag.description = "Doorema Soru ve Cevap";
            ViewBag.keywords = "soru ve cevap,doorema,çelik kapı,yangın kapıları";
            var result = _db.Faqs.ToList();
            return View(result);
        }
        public IActionResult Documents()
        {
            ViewBag.title = "Belgeler | doorema.com.tr";
            ViewBag.description = "Doorema Belgeler";
            ViewBag.keywords = "belgeler,doorema,çelik kapı,yangın kapıları";
            var doc = _db.Documents.ToList();
            return View(doc);
        }
        public IActionResult References()
        {
            ViewBag.title = "Referanslar | doorema.com.tr";
            ViewBag.description = "Doorema Referanslar";
            ViewBag.keywords = "referanslar,doorema,çelik kapı,yangın kapıları";
            var refe = _db.Reference.ToList();
            return View(refe);
        }
        public IActionResult Technical()
        {
            ViewBag.title = "Teknik Bilgi | doorema.com.tr";
            ViewBag.description = "Doorema Teknik Bilgi";
            ViewBag.keywords = "teknik bilgi,doorema,çelik kapı,yangın kapıları";
            var tec = _db.Technicals.ToList();
            return View(tec);
        }
        public IActionResult ProjectManeger()
        {
            ViewBag.title = "Proje Yönetimi | doorema.com.tr";
            ViewBag.description = "Doorema Proje Yönetimi";
            ViewBag.keywords = "proje yönetimi,doorema,çelik kapı,yangın kapıları";
            return View();
        }
        public IActionResult KatologPdf()
        {

            return View();
        }
        public IActionResult b1()
        {

            return View();
        }
        public IActionResult details()
        {

            return View();
        }

        public IActionResult Contact()
        {
            ViewBag.title = "İletişim | doorema.com.tr";
            ViewBag.description = "Doorema İletişim";
            ViewBag.keywords = "iletişim,doorema,çelik kapı,yangın kapıları";
            return View();
        }
        public IActionResult Hata(int code)
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Contact(ContactModel model)
        {
            if (ModelState.IsValid)
            {
                var body = new StringBuilder();
                body.AppendLine("Adınız: " + model.NameLastName + "<br />");
                body.AppendLine("E-mail: " + model.Email + "<br />");
                body.AppendLine("Mesaj: " + model.Message + "<br />");
                await SendEmail(model.NameLastName + "  <br /> " + model.Email + " <br /> " + model.Message);
                ViewBag.Success = true;
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SendEmail(string emailMessage)
        {
#pragma warning disable CS0168 // The variable 'ex' is declared but never used
            try
            {
                var message = new MailMessage();
                var fromAddress = new MailAddress("ema@emacelikkapi.com", "Web Sitesinden Gelen İletişim Formu...");
                var toAddress = new MailAddress("ema@emacelikkapi.com");
                const string subject = "İletişim Formu";
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
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index");
            }
#pragma warning restore CS0168 // The variable 'ex' is declared but never used
        }
        [HttpPost]
        public IActionResult SearchList(string searchText)
        {
            ViewBag.title = "Arama Listesi | doorema.com.tr";
            ViewBag.description = "Doorema Arama Listesi";
            ViewBag.keywords = "arama listesi,doorema,çelik kapı,yangın kapıları";
            var products = _db.Products.Where(x => x.ProductName.TrimEnd().Contains(searchText) || x.StockCode.TrimEnd().Contains(searchText) || x.Description.TrimEnd().Contains(searchText) || x.Keywords.TrimEnd().Contains(searchText));
            var cate = _db.SubCategories.Where(x => x.MetaTitle.TrimEnd().Contains(searchText));
            return View(products.ToList());
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}