using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using cateringAndRent.Models;

namespace cateringAndRent.Controllers;

public class RentController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public RentController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Booking() {
        return View();
    }
}