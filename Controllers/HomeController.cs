using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AustraliaWideEducation.Models;

namespace AustraliaWideEducation.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Process()
    {
        return View();
    }
    public IActionResult Services()
    {
        return View();
    }
    public IActionResult FAQs()
    {
        return View();
    }
    public IActionResult AboutUs()
    {
        return View();
    }
    public IActionResult Contact()
    {
        return View();
    }
    public IActionResult Apply()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

