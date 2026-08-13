using Microsoft.AspNetCore.Mvc;

namespace MyWebPage.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult About()
    {
        return View();
    }

    public IActionResult Error()
    {
        return View();
    }
}
