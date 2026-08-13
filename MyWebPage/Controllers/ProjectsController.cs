using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyWebPage.Data;

namespace MyWebPage.Controllers;

public class ProjectsController : Controller
{
    private readonly AppDbContext _context;

    public ProjectsController(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        var projects = await _context.Projects.OrderByDescending(p => p.CreatedAt).ToListAsync();
        return View(projects);
    }

    public async Task<IActionResult> Details(int id)
    {
        var project = await _context.Projects.FindAsync(id);
        if (project == null)
            return NotFound();
        return View(project);
    }
}
