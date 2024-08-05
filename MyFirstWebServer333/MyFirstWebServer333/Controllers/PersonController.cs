using Microsoft.AspNetCore.Mvc;
using MyFirstWebServer333.Data;
using MyFirstWebServer333.Models.Entities;

namespace MyFirstWebServer333.Controllers;

public class PersonController : Controller
{
    private readonly ApplicationDbContext _context;
    
    /// <summary>
    /// Создает класс контроллер
    /// </summary>
    /// <param name="context">Соединение с БД</param>
    public PersonController(ApplicationDbContext context)
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
        int age,
        string gender
        )
    {
        PersonModel newPerson = new PersonModel();
        newPerson.Name = name;
        newPerson.Age = age;
        newPerson.Gender = gender;
        _context.Add(newPerson);
        _context.SaveChangesAsync();
        ViewBag.person = newPerson;
        return View();
    }
}