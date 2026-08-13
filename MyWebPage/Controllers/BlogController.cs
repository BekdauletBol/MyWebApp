using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyWebPage.Data;

namespace MyWebPage.Controllers;

public class BlogController : Controller
{
    private readonly AppDbContext _context;

    public BlogController(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        var posts = await _context.BlogPosts.OrderByDescending(p => p.CreatedAt).ToListAsync();
        return View(posts);
    }

    public async Task<IActionResult> Details(int id)
    {
        var post = await _context.BlogPosts.FindAsync(id);
        if (post == null)
            return NotFound();
        return View(post);
    }
}
