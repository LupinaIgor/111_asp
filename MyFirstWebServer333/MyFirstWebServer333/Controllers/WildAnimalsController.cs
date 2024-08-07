using Microsoft.AspNetCore.Mvc;

namespace MyFirstWebServer333.Controllers;

public class WildAnimalsController : Controller
{
    // GET
    public IActionResult GetWolfInfo()
    {
        var wolfInfo = "Крупное хищное млекопитающее"; 
        return Content(wolfInfo); 
    }
    
    public IActionResult GetFoxInfo()
    {
        var foxInfo = "это хищное млекопитающее семейства псовых";
        return Content(foxInfo); 
    }    
}