using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using Blog.Domain.Entities;

namespace Blog.Infrastructure.Models;

public class ApplicationUser : IdentityUser
{
    [Required]
    public string DisplayName { get; set; } = string.Empty;
    
    public string Bio { get; set; } = string.Empty;
    
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
} 