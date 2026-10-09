using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Prog3000Assignment1Vishva.Models;
using Prog3000Assignment1Vishva.Repositories;

namespace Prog3000Assignment1Vishva.Controllers;

public class HomeController : Controller
{
    private readonly EquipmentRequestRepository _requests = new();

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

    [HttpGet("/RequestForm")]
    public IActionResult RequestForm()
    {
        return View(new EquipmentRequest());
    }

    [HttpPost("/RequestForm")]
    [ValidateAntiForgeryToken]
    public IActionResult RequestForm(EquipmentRequest request)
    {
        if (!ModelState.IsValid)
        {
            return View(request);
        }

        _requests.Add(request);
        return RedirectToAction(nameof(Confirmation));
    }

    public IActionResult Confirmation()
    {
        return View();
    }

    

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}