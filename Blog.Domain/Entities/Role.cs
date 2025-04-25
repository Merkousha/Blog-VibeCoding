using Microsoft.AspNetCore.Identity;

namespace Blog.Domain.Entities;

public class Role : IdentityRole
{
    public string Description { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? LastModifiedAt { get; set; }
} 