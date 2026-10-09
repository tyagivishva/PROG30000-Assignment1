using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Prog3000Assignment1Vishva.Models;

namespace Prog3000Assignment1Vishva.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult EquipmentListing()
    {
        return View();
    }

    public IActionResult AvailableEquipment()
    {
        return View();
    }

    public IActionResult RequestForm()
    {
        return View();
    }

    

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}