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
    public IActionResult Check(Feedback contact)
    {
        if (ModelState.IsValid)
        {
            _context.Feedbacks.Add(contact);
            _context.SaveChanges();
            return Redirect("/");
        }
        return View("Index", contact);
    }
}
