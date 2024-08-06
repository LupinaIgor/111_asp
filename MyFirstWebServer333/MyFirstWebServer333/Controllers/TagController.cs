using Microsoft.AspNetCore.Mvc;
using MyFirstWebServer333.Data;
using MyFirstWebServer333.Models.Entities;

namespace MyFirstWebServer333.Controllers;

public class TagController : Controller
{
    
    private readonly ApplicationDbContext _context;
    
    /// <summary>
    /// Создает класс контроллер
    /// </summary>
    /// <param name="context">Соединение с БД</param>
    public TagController(ApplicationDbContext context)
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
        string description
    )
    {
        TagModel newTag = new TagModel();
        newTag.Name = name;
        newTag.Description = description;
        _context.Add(newTag);
        _context.SaveChangesAsync();
        ViewBag.tag = newTag;
        return View();
    }
}