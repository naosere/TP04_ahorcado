using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Tp04_ahorcado.Models;

namespace Tp04_ahorcado.Controllers;

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
}
