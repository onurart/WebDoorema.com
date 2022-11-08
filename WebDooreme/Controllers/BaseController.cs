using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
namespace WebDooreme.Controllers
{
    public class BaseController : Controller
    {
        [Authorize]
        public IActionResult Index()
        {
            return View();
        }
    }
}