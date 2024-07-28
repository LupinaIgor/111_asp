using Microsoft.AspNetCore.Mvc;

namespace MyFirstWebServer222.Controllers;

public class ContactController : Controller
{
    public IActionResult Form()
    {
        return View();
    } 
}