using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
namespace WebDooreme.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Blog()
        {
            return View();
        }
    }
}