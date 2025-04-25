using Blog.Application.Services;
using Blog.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Presentation.Controllers;

public class PostController : Controller
{
    private readonly PostService _postService;

    public PostController(PostService postService)
    {
        _postService = postService;
    }

    public async Task<IActionResult> Index()
    {
        var posts = await _postService.GetAllPostsAsync();
        return View(posts);
    }

    public async Task<IActionResult> Details(int id)
    {
        var post = await _postService.GetPostByIdAsync(id);
        if (post == null)
        {
            return NotFound();
        }
        return View(post);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(Post post)
    {
        if (ModelState.IsValid)
        {
            await _postService.CreatePostAsync(post);
            return RedirectToAction(nameof(Index));
        }
        return View(post);
    }

    public async Task<IActionResult> Edit(int id)
    {
        var post = await _postService.GetPostByIdAsync(id);
        if (post == null)
        {
            return NotFound();
        }
        return View(post);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int id, Post post)
    {
        if (id != post.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            await _postService.UpdatePostAsync(post);
            return RedirectToAction(nameof(Index));
        }
        return View(post);
    }

    public async Task<IActionResult> Delete(int id)
    {
        var post = await _postService.GetPostByIdAsync(id);
        if (post == null)
        {
            return NotFound();
        }
        return View(post);
    }

    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _postService.DeletePostAsync(id);
        return RedirectToAction(nameof(Index));
    }
} 