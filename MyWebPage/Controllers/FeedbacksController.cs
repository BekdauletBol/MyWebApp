using Microsoft.AspNetCore.Mvc;

namespace MyWebPage.Controllers
{
    public class FeedbacksController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}