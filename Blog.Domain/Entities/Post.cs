using System.ComponentModel.DataAnnotations;

namespace Blog.Domain.Entities;

public class Post
{
    public int Id { get; set; }

    [Required]
    public string Title { get; set; } = string.Empty;

    [Required]
    public string Content { get; set; } = string.Empty;

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    [Required]
    public string AuthorId { get; set; } = string.Empty;

    public virtual User Author { get; set; } = null!;

    public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();

    public bool IsPublished { get; set; }
}