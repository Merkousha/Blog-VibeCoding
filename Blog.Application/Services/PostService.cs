using Blog.Domain.Entities;
using Blog.Domain.Interfaces;

namespace Blog.Application.Services;

public class PostService
{
    private readonly IPostRepository _postRepository;

    public PostService(IPostRepository postRepository)
    {
        _postRepository = postRepository;
    }

    public async Task<Post?> GetPostByIdAsync(int id)
    {
        return await _postRepository.GetByIdAsync(id);
    }

    public async Task<IEnumerable<Post>> GetAllPostsAsync()
    {
        return await _postRepository.GetAllAsync();
    }

    public async Task<Post> CreatePostAsync(Post post)
    {
        post.CreatedAt = DateTime.UtcNow;
        return await _postRepository.AddAsync(post);
    }

    public async Task UpdatePostAsync(Post post)
    {
        post.UpdatedAt = DateTime.UtcNow;
        await _postRepository.UpdateAsync(post);
    }

    public async Task DeletePostAsync(int id)
    {
        await _postRepository.DeleteAsync(id);
    }
} 