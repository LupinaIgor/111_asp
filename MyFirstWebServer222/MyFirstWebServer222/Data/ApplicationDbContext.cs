using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyFirstWebServer222.Models.Entities;

namespace MyFirstWebServer222.Data;

public class ApplicationDbContext : IdentityDbContext
{
    
    private DbSet<SubscribeModel> Subscribers { get; set; }
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
}