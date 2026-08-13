using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyWebPage.Data;
using MyWebPage.Models;

namespace MyWebPage.Controllers;

public class AdminController : Controller
{
    private readonly AppDbContext _context;

    public AdminController(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        var feedbacks = await _context.Feedbacks.OrderByDescending(f => f.CreatedAt).ToListAsync();
        return View(feedbacks);
    }

    public async Task<IActionResult> Projects()
    {
        var projects = await _context.Projects.OrderByDescending(p => p.CreatedAt).ToListAsync();
        return View(projects);
    }

    public async Task<IActionResult> Blog()
    {
        var posts = await _context.BlogPosts.OrderByDescending(p => p.CreatedAt).ToListAsync();
        return View(posts);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult DeleteFeedback(int id)
    {
        var feedback = _context.Feedbacks.Find(id);
        if (feedback != null)
        {
            _context.Feedbacks.Remove(feedback);
            _context.SaveChanges();
        }
        return RedirectToAction("Index");
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult DeleteProject(int id)
    {
        var project = _context.Projects.Find(id);
        if (project != null)
        {
            _context.Projects.Remove(project);
            _context.SaveChanges();
        }
        return RedirectToAction("Projects");
    }

    public IActionResult CreateProject()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult CreateProject(Project project)
    {
        if (ModelState.IsValid)
        {
            project.CreatedAt = DateTime.UtcNow;
            _context.Projects.Add(project);
            _context.SaveChanges();
            return RedirectToAction("Projects");
        }
        return View(project);
    }

    public async Task<IActionResult> CreatePost()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult CreatePost(BlogPost post)
    {
        if (ModelState.IsValid)
        {
            post.CreatedAt = DateTime.UtcNow;
            _context.BlogPosts.Add(post);
            _context.SaveChanges();
            return RedirectToAction("Blog");
        }
        return View(post);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult DeletePost(int id)
    {
        var post = _context.BlogPosts.Find(id);
        if (post != null)
        {
            _context.BlogPosts.Remove(post);
            _context.SaveChanges();
        }
        return RedirectToAction("Blog");
    }
}
