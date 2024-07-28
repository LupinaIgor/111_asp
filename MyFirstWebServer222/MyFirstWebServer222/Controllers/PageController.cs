using Microsoft.AspNetCore.Mvc;

namespace MyFirstWebServer222.Controllers;

public class PageController : Controller
{
    public IActionResult About()
    {
        return View();
    }
}