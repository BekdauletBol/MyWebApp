using Microsoft.AspNetCore.Mvc;
using MyWebPage.Data;
using MyWebPage.Models;

namespace MyWebPage.Controllers;

public class FeedbacksController : Controller
{
    private readonly AppDbContext _context;

    public FeedbacksController(AppDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(Feedback feedback)
    {
        if (ModelState.IsValid)
        {
            feedback.CreatedAt = DateTime.UtcNow;
            _context.Feedbacks.Add(feedback);
            _context.SaveChanges();
            return RedirectToAction("Success");
        }
        return View("Index", feedback);
    }

    public IActionResult Success()
    {
        return View();
    }
}
