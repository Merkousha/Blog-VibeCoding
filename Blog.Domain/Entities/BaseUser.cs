using System.ComponentModel.DataAnnotations;

namespace Blog.Domain.Entities;

public class BaseUser
{
    [Key]
    public string Id { get; set; } = string.Empty;
    
    [Required]
    public string UserName { get; set; } = string.Empty;
    
    [Required]
    public string DisplayName { get; set; } = string.Empty;
    
    public string Bio { get; set; } = string.Empty;
} 