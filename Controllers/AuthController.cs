using Microsoft.AspNetCore.Mvc;

using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Inventory_M.Models;
namespace Inventory_M.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Login()
        {
            ClaimsPrincipal claimUser = HttpContext.User;

            if (claimUser.Identity.IsAuthenticated)
                return RedirectToAction("Index", "Home");


            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(AuthViewModel modelLogin)
        {
            Console.WriteLine("modelLogin.Email: " + modelLogin.Email + " and modelLogin.PassWord " + modelLogin.PassWord);

            if (modelLogin.Email == "user@gmail.com" &&
                modelLogin.PassWord == "a"
                )
            { 
                List<Claim> claims = new List<Claim>() { 
                    new Claim(ClaimTypes.NameIdentifier, modelLogin.Email),
                    new Claim("OtherProperties","Example Role")
                
                };

                ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims,
                    CookieAuthenticationDefaults.AuthenticationScheme );

                AuthenticationProperties properties = new AuthenticationProperties()
                {

                    AllowRefresh = true,
                    IsPersistent = modelLogin.KeepLoggedIn
            };

                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(claimsIdentity), properties);
            
                return RedirectToAction("Index", "Home");
            }



            ViewData["ValidateMessage"] = "Invalid email or password. Please try again.";
            return View();
        }
    }
}








