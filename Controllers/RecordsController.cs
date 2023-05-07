using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Inventory_M.Models;

using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Inventory_M.Data;
using Microsoft.EntityFrameworkCore;
using Inventory_M.Models.ViewModels;

namespace Inventory_M.Controllers;

public class RecordsController : Controller
{
    
   // show smia dial l action method

   [HttpGet]
    public IActionResult Show()
{
    return View();
}


    

}