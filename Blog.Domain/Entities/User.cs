using System;
using Microsoft.AspNetCore.Identity;

namespace Blog.Domain.Entities;

public class User : IdentityUser
{
    public string DisplayName { get; set; }
    public string Bio { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? LastModifiedAt { get; set; }
    public bool IsActive { get; set; } = true;
} 