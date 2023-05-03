using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Inventory_M.Models;

using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Inventory_M.Data;
using Microsoft.EntityFrameworkCore;
using Inventory_M.Models.ViewModels;

namespace Inventory_M.Controllers;

public class EmployeeController : Controller
{
    private readonly ILogger<EmployeeController> _logger;
    private readonly InventoryDbContext _context;

    public EmployeeController(ILogger<EmployeeController> logger, InventoryDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    public IActionResult Show()
{
    var viewModel = new EmployeeViewModel();
    viewModel.Users = _context.Users.ToList();
    viewModel.URoles = _context.Roles.ToList();

    return View(viewModel);
}


    

}
