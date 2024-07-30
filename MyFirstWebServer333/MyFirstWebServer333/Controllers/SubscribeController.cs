using Microsoft.AspNetCore.Mvc;
using MyFirstWebServer333.Data;
using MyFirstWebServer333.Models.Entities;

namespace MyFirstWebServer333.Controllers;

public class SubscribeController : Controller
{
    
    private readonly ApplicationDbContext _context;
    
    /// <summary>
    /// Создает класс контроллер
    /// </summary>
    /// <param name="context">Соединение с БД</param>
    public SubscribeController(ApplicationDbContext context)
    {
        _context = context;
    }
    /// <summary>
    /// Add user email to DB 
    /// </summary>
    /// <param name="email">User email</param>
    /// <returns></returns>

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult SaveEmail(String email)
    {
        ViewBag.email = email;

        SubscribeModel newSubscriber = new SubscribeModel();
        newSubscriber.Email = email;

        //ApplicationDbContext db = new ApplicationDbContext();

        _context.Subscribers.Add(newSubscriber);
        _context.SaveChangesAsync();
        
        return View();
    } 
}
