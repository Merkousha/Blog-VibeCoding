using Blog.Domain.Entities;

namespace Blog.Domain.Interfaces;

public interface IPostRepository
{
    Task<Post?> GetByIdAsync(int id);
    Task<IEnumerable<Post>> GetAllAsync();
    Task<Post> AddAsync(Post post);
    Task UpdateAsync(Post post);
    Task DeleteAsync(int id);
} 