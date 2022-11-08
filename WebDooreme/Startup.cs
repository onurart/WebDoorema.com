using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WebDooreme.Models;

namespace WebDooreme
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }
        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvcCore();
            services.AddControllersWithViews().AddRazorRuntimeCompilation();
            services.AddDbContext<sifatakiContext>(opt => opt.UseSqlServer(Configuration.GetConnectionString("DefaultConnectionString")));
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(options =>
            {
                options.LoginPath = "/login";
            });
            services.AddHttpContextAccessor();
            // If using Kestrel:
            services.Configure<KestrelServerOptions>(options =>
            {
                options.AllowSynchronousIO = true;
            });
            // If using IIS:
            services.Configure<IISServerOptions>(options =>
            {
                options.AllowSynchronousIO = true;
            });
        }
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseStatusCodePages();
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(name: "anasayfa1", pattern: "anasayfa", new { controller = "Home", action = "Index" });
                endpoints.MapControllerRoute(name: "anasayfa2", pattern: "", new { controller = "Home", action = "Index" });
                endpoints.MapControllerRoute(name: "kurumsal", pattern: "kurumsal", new { controller = "Home", action = "Institutional" });
                endpoints.MapControllerRoute(name: "teknikbilgi", pattern: "teknik-bilgi", new { controller = "Home", action = "Technical" });
                endpoints.MapControllerRoute(name: "projeyonetimi", pattern: "proje-yonetimi", new { controller = "Home", action = "ProjectManeger" });
                endpoints.MapControllerRoute(name: "referanslar", pattern: "referanslar", new { controller = "Home", action = "References" });
                endpoints.MapControllerRoute(name: "belgeler", pattern: "belgeler", new { controller = "Home", action = "Documents" });
                endpoints.MapControllerRoute(name: "contact", pattern: "iletisim", new { controller = "Home", action = "Contact" });
                endpoints.MapControllerRoute(name: "faq", pattern: "soru-cevap", new { controller = "Home", action = "faq" });
                endpoints.MapControllerRoute(name: "blog", pattern: "blog", new { controller = "Blog", action = "Index" });
                endpoints.MapControllerRoute(name: "KatologPdf", pattern: "KatologPdf", new { controller = "Home", action = "KatologPdf" });
                endpoints.MapControllerRoute(name: "b1", pattern: "b1", new { controller = "Home", action = "b1" });

                endpoints.MapControllerRoute(name: "blogdetay", pattern: "blog/detay/{title}/{id}", defaults: new { controller = "Blog", action = "Details" });
                endpoints.MapControllerRoute(name: "aramalistesi", pattern: "arama-listesi", defaults: new { controller = "Home", action = "SearchList" });
                endpoints.MapControllerRoute(name: "urunanakategori", pattern: "urun/ana-kategori/{title}/{categoryId}", defaults: new { controller = "Product", action = "ProductToCategory" });
                endpoints.MapControllerRoute(name: "urunaltkategori", pattern: "urun/alt-kategori/{title}/{categoryId}/{subCategoryId}", defaults: new { controller = "Product", action = "ProductToSubCategory" });
                endpoints.MapControllerRoute(name: "urundetay", pattern: "urun/detay/{title}/{stockCode}", defaults: new { controller = "Product", action = "Details" });
                //Admin
                endpoints.MapControllerRoute(name: "admin", pattern: "admin", new { controller = "Admin", action = "Index" });
                endpoints.MapControllerRoute(name: "login", pattern: "login", new { controller = "WebLogin", action = "Login" });
                endpoints.MapControllerRoute(name: "adminblogs", pattern: "admin-blog", new { controller = "AdminBlogs", action = "Index" });
                endpoints.MapControllerRoute(name: "adminproducts", pattern: "admin-urun", new { controller = "AdminProducts", action = "Index" });
                endpoints.MapControllerRoute(name: "adminsliders", pattern: "admin-slider", new { controller = "AdminSliders", action = "Index" });
                endpoints.MapControllerRoute(name: "adminreferences", pattern: "admin-referans", new { controller = "AdminReferences", action = "Index" });
                endpoints.MapControllerRoute(name: "admintechnicals", pattern: "admin-teknik-bilgi", new { controller = "AdminTechnicals", action = "Index" });
                endpoints.MapControllerRoute(name: "admindocuments", pattern: "admin-belge", new { controller = "AdminDocuments", action = "Index" });
                endpoints.MapControllerRoute(name: "admininstitutionals", pattern: "admin-kurumsal", new { controller = "AdminInstitutionals", action = "Index" });
                endpoints.MapControllerRoute(name: "admincategories", pattern: "admin-kategori", new { controller = "AdminCategories", action = "Index" });
                endpoints.MapControllerRoute(name: "admincategoriescreate", pattern: "admin-kategori-ekle", new { controller = "AdminCategories", action = "Create" });
                endpoints.MapControllerRoute(name: "admincategoriesedit", pattern: "admin-kategori-duzenle/{id}", new { controller = "AdminCategories", action = "Edit" });
                endpoints.MapControllerRoute(name: "admincategoriesdelete", pattern: "admin-kategori-sil/{id}", new { controller = "AdminCategories", action = "Delete" });
                endpoints.MapControllerRoute(name: "admincategoriesdetails", pattern: "admin-kategori-detay/{id}", new { controller = "AdminCategories", action = "Details" });
                endpoints.MapControllerRoute(name: "adminblogs", pattern: "admin-blog", new { controller = "AdminBlogs", action = "Index" });
                endpoints.MapControllerRoute(name: "adminblogscreate", pattern: "admin-blog-ekle", new { controller = "AdminBlogs", action = "Create" });
                endpoints.MapControllerRoute(name: "adminblogsedit", pattern: "admin-blog-duzenle/{id}", new { controller = "AdminBlogs", action = "Edit" });
                endpoints.MapControllerRoute(name: "adminblogsdelete", pattern: "admin-blog-sil/{id}", new { controller = "AdminBlogs", action = "Delete" });
                endpoints.MapControllerRoute(name: "adminblogsdetails", pattern: "admin-blog-detay/{id}", new { controller = "AdminBlogs", action = "Details" });
                endpoints.MapControllerRoute(name: "adminproducts", pattern: "admin-urun", new { controller = "AdminProducts", action = "Index" });
                endpoints.MapControllerRoute(name: "adminproductscreate", pattern: "admin-urun-ekle", new { controller = "AdminProducts", action = "Create" });
                endpoints.MapControllerRoute(name: "adminproductsedit", pattern: "admin-urun-duzenle/{id}", new { controller = "AdminProducts", action = "Edit" });
                endpoints.MapControllerRoute(name: "adminproductsdelete", pattern: "admin-urun-sil/{id}", new { controller = "AdminProducts", action = "Delete" });
                endpoints.MapControllerRoute(name: "adminproductsdetails", pattern: "admin-urun-detay/{id}", new { controller = "AdminProducts", action = "Details" });
                endpoints.MapControllerRoute(name: "adminsliders", pattern: "admin-slider", new { controller = "AdminSliders", action = "Index" });
                endpoints.MapControllerRoute(name: "adminsliderscreate", pattern: "admin-slider-ekle", new { controller = "AdminSliders", action = "Create" });
                endpoints.MapControllerRoute(name: "adminslidersedit", pattern: "admin-slider-duzenle/{id}", new { controller = "AdminSliders", action = "Edit" });
                endpoints.MapControllerRoute(name: "adminslidersdelete", pattern: "admin-slider-sil/{id}", new { controller = "AdminSliders", action = "Delete" });
                endpoints.MapControllerRoute(name: "adminslidersdetails", pattern: "admin-slider-detay/{id}", new { controller = "AdminSliders", action = "Details" });
                endpoints.MapControllerRoute(name: "adminreferences", pattern: "admin-referans", new { controller = "AdminReferences", action = "Index" });
                //endpoints.MapControllerRoute(name: "adminreferencescreate", pattern: "admin-referans-ekle", new { controller = "AdminReferences", action = "Create" });
                endpoints.MapControllerRoute(name: "adminreferencesedit", pattern: "admin-referans-duzenle/{id}", new { controller = "AdminReferences", action = "Edit" });
                endpoints.MapControllerRoute(name: "adminreferencesdelete", pattern: "admin-referans-sil/{id}", new { controller = "AdminReferences", action = "Delete" });
                endpoints.MapControllerRoute(name: "adminreferencesdetails", pattern: "admin-referans-detay/{id}", new { controller = "AdminReferences", action = "Details" });
                endpoints.MapControllerRoute(name: "admintechnicals", pattern: "admin-teknik-bilgi", new { controller = "AdminTechnicals", action = "Index" });
                endpoints.MapControllerRoute(name: "admintechnicalscreate", pattern: "admin-teknik-bilgi-ekle", new { controller = "AdminTechnicals", action = "Create" });
                endpoints.MapControllerRoute(name: "admintechnicalsedit", pattern: "admin-teknik-bilgi-duzenle/{id}", new { controller = "AdminTechnicals", action = "Edit" });
                endpoints.MapControllerRoute(name: "admintechnicalsdelete", pattern: "admin-teknik-bilgi-sil/{id}", new { controller = "AdminTechnicals", action = "Delete" });
                endpoints.MapControllerRoute(name: "admintechnicalsdetails", pattern: "admin-teknik-bilgi-detay/{id}", new { controller = "AdminTechnicals", action = "Details" });
                endpoints.MapControllerRoute(name: "admindocuments", pattern: "admin-belgeler", new { controller = "AdminDocuments", action = "Index" });
                endpoints.MapControllerRoute(name: "admindocumentscreate", pattern: "admin-belgeler-ekle", new { controller = "AdminDocuments", action = "Create" });
                endpoints.MapControllerRoute(name: "admindocumentsedit", pattern: "admin-belgeler-duzenle/{id}", new { controller = "AdminDocuments", action = "Edit" });
                endpoints.MapControllerRoute(name: "admindocumentsdelete", pattern: "admin-belgeler-sil/{id}", new { controller = "AdminDocuments", action = "Delete" });
                endpoints.MapControllerRoute(name: "admindocumentsdetails", pattern: "admin-belgeler-detay/{id}", new { controller = "AdminDocuments", action = "Details" });
                endpoints.MapControllerRoute(name: "admininstitutionals", pattern: "admin-kurumsal", new { controller = "AdminInstitutionals", action = "Index" });
                endpoints.MapControllerRoute(name: "admininstitutionalscreate", pattern: "admin-kurumsal-ekle", new { controller = "AdminInstitutionals", action = "Create" });
                endpoints.MapControllerRoute(name: "admininstitutionalsedit", pattern: "admin-kurumsal-duzenle/{id}", new { controller = "AdminInstitutionals", action = "Edit" });
                endpoints.MapControllerRoute(name: "admininstitutionalsdelete", pattern: "admin-kurumsal-sil/{id}", new { controller = "AdminInstitutionals", action = "Delete" });
                endpoints.MapControllerRoute(name: "admininstitutionalsdetails", pattern: "admin-kurumsal-detay/{id}", new { controller = "AdminInstitutionals", action = "Details" });
                endpoints.MapControllerRoute(name: "musteriMail", pattern: "musteri-mail", new { controller = "Home", action = "SendEmail" });
                endpoints.MapControllerRoute(name: "adminreferencescreate", pattern: "admin-referans-ekle", new { controller = "AdminReferences", action = "Create" });
                endpoints.MapControllerRoute(name: "adminFaq", pattern: "wwww", new { controller = "AdminFaq", action = "Index" });
                endpoints.MapControllerRoute(name: "adminFaq", pattern: "crx", new { controller = "AdminFaq", action = "Create" });
                endpoints.MapControllerRoute(name: "adminFaq", pattern: "crxx", new { controller = "AdminFaq", action = "Edit" });
                endpoints.MapControllerRoute(name: "adminFaq", pattern: "crzz", new { controller = "AdminFaq", action = "Delete" });
                endpoints.MapControllerRoute(name: "ReferansTables", pattern: "ReferansTables", new { controller = "ReferansTables", action = "Index" });
                endpoints.MapControllerRoute(name: "ReferansTables", pattern: "ReferansTables", new { controller = "ReferansTables", action = "Index" });
                endpoints.MapControllerRoute(name: "ReferansTables", pattern: "admin-ref", new { controller = "ReferansTables", action = "Create" });
                endpoints.MapControllerRoute(name: "ReferansTables", pattern: "admin-ref-silme", new { controller = "ReferansTables", action = "Delete" });
                endpoints.MapControllerRoute(name: "ReferansTables", pattern: "admin-ref-duzenle/{id}", new { controller = "ReferansTables", action = "Edit" });



                endpoints.MapControllerRoute(name: "faq", pattern: "soru-cevap", new { controller = "Home", action = "faq" });



            });
        }
    }
}