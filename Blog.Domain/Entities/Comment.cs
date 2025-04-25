using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace Blog.Domain.Entities;

public class Comment
{
    public int Id { get; set; }
    
    [Required]
    public string Content { get; set; } = string.Empty;
    
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    
    public DateTime? UpdatedAt { get; set; }
    
    [Required]
    public string AuthorId { get; set; } = string.Empty;
    
    public virtual User Author { get; set; } = null!;
    
    public int PostId { get; set; }
    
    public virtual Post Post { get; set; } = null!;
} 