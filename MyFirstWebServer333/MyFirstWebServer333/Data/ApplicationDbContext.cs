using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyFirstWebServer333.Models.Entities;

namespace MyFirstWebServer333.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public DbSet<SubscribeModel> Subscribers { get; set; }
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    
    public DbSet<PersonModel> Persons { get; set; }
    public DbSet<CategoryModel> Category { get; set; }
    
    public DbSet<TagModel> Tag { get; set; } 
    
    public DbSet<VendorModel> Vendor { get; set; }
}