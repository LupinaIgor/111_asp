using Microsoft.AspNetCore.Mvc;
using MyFirstWebServer333.Data;
using MyFirstWebServer333.Models.Entities;

namespace MyFirstWebServer333.Controllers;

public class CategoryController : Controller
{
    
    private readonly ApplicationDbContext _context;
    
    /// <summary>
    /// Создает класс контроллер
    /// </summary>
    /// <param name="context">Соединение с БД</param>
    public CategoryController(ApplicationDbContext context)
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
        CategoryModel newCategory = new CategoryModel();
        newCategory.Name = name;
        newCategory.Description = description;
        _context.Add(newCategory);
        _context.SaveChangesAsync();
        ViewBag.category = newCategory;
        return View();
    }
}