using Microsoft.AspNetCore.Mvc;

namespace MyFirstWebServer333.Controllers;

public class DomesticAnimalController : Controller
{
    // GET
    public IActionResult GetCatInfo()
    {
        var catInfo = "это домашнее животное, вид мелкого хищного млекопитающего."; 
        return Content(catInfo); 
    }
    
    public IActionResult GetDogInfo()
    {
        var dogInfo = "домашнее животное, одно из наиболее популярных животных-компаньонов.";
        return Content(dogInfo); 
    }    
   
}