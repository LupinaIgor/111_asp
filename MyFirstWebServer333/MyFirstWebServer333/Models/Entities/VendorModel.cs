using System.ComponentModel.DataAnnotations.Schema;

namespace MyFirstWebServer333.Models.Entities;

public class VendorModel
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    
    public string Name { get; set; }
    
    public string Country { get; set; }
    
    public string Email { get; set; }
}