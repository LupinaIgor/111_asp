using Microsoft.AspNetCore.Mvc;

namespace MyFirstWebServer333.Controllers;

public class ContactController : Controller
{
    public IActionResult Form()
    {
        return View();
    }  
}