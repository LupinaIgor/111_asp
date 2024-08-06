﻿using System.ComponentModel.DataAnnotations.Schema;

namespace MyFirstWebServer333.Models.Entities;

public class TagModel
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    
    public string Name { get; set; }
    
    public string Description { get; set; } 
   
}