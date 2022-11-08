using Microsoft.AspNetCore.Mvc;
namespace WebDooreme.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}