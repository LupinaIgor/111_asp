using Microsoft.AspNetCore.Mvc;
using MyFirstWebServer333.Data;
using MyFirstWebServer333.Models.Entities;

namespace MyFirstWebServer333.Controllers;

public class VendorController : Controller
{

    private readonly ApplicationDbContext _context;

    /// <summary>
    /// Создает класс контроллер
    /// </summary>
    /// <param name="context">Соединение с БД</param>
    public VendorController(ApplicationDbContext context)
    {
        _context = context;
    }

    // GET
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(
        string name,
        string country,
        string email
    )
    {
        VendorModel newVendor = new VendorModel();
        newVendor.Name = name;
        newVendor.Country = country;
        newVendor.Email = email;
        _context.Add(newVendor);
        _context.SaveChangesAsync();
        ViewBag.vendor = newVendor;
        return View();
    }
}
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    