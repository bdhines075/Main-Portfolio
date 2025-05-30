using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using GroupProject2.Models;
using GroupProject2.Data;


namespace GroupProject2.Controllers
{ }

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IDAL _idal;
    public HomeController(ILogger<HomeController> logger, IDAL idal)
    {
        _logger = logger;
        _idal = idal;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        var myevent = _idal.GetEvent(1);
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
