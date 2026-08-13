using Microsoft.AspNetCore.Mvc;
using MyWebPage.Models;

namespace MyWebPage.Controllers
{
    public class FeedbacksController : Controller
    {   
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Check (Feedback contact)
        {
            if(ModelState.IsValid)
            {
                return Redirect("/");
            }
            else
            {
                return View("Index");
            }
        }
    }
}