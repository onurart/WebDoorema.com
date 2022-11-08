using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using WebDooreme.Models;
namespace WebDooreme.Controllers
{
    public class WebLoginController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(User loginModel)
        {
            if (LoginUser(loginModel.UserName, loginModel.Password))
            {
                var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, loginModel.UserName)
            };
                var userIdentity = new ClaimsIdentity(claims, "login");
                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
                await HttpContext.SignInAsync(principal);
                //Just redirect to our index after logging in.
                return RedirectToAction("Index", "Admin");
            }
            return View();
        }
        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
        private bool LoginUser(string username, string password)
        {
            if (username == "burak" && password == "123")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}