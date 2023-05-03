using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Inventory_M.Models;

using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Inventory_M.Data;
using Microsoft.EntityFrameworkCore;


namespace Inventory_M.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly InventoryDbContext _context;

    public HomeController(ILogger<HomeController> logger, InventoryDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    public IActionResult Index()
    {
        ViewBag.UserName = HttpContext.Session.GetString("username");
        ViewBag.UserLname = HttpContext.Session.GetString("userlname");
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }



    public async Task<IActionResult> LogOut()
    {
        // Get the UserId from the session
    var userId = HttpContext.Session.GetInt32("UserId");
    
    // Retrieve the user from the database
    var user = _context.Users.SingleOrDefault(u => u.UserId == userId);


    if (user != null)
    {
        // Update the user's status
        user.status = false;
        _context.SaveChanges();
    }

    // Remove the session
    HttpContext.Session.Clear();

    await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
    return RedirectToAction("Login", "Auth");
    
    }



    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }


    

    
}
