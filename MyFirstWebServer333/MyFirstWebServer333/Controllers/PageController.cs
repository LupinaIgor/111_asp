using Microsoft.AspNetCore.Mvc;

namespace MyFirstWebServer333.Controllers;

public class PageController : Controller
{
    public IActionResult About()
    {
        return View();
    } 
}