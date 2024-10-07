using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyApp.Models;
using MyApp.ViewModels;

namespace MyApp.Controllers;

public class HomeController(ILogger<HomeController> logger) : Controller
{
    private readonly ILogger<HomeController> _logger = logger;

    public IActionResult Index()
    {
        return View();
    }
    
    public IActionResult Components()
    {
        return View();
    }
    
    public IActionResult Forms()
    {
        return View();
    }
    
    [HttpPost]
    public IActionResult Forms(ItemsViewModel viewModel)
    {
        if (ModelState.IsValid)
        {
            return RedirectToAction(nameof(Index));
        }

        // If validation fails, return to the view
        return View(viewModel);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}