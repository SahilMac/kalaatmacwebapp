using Microsoft.AspNetCore.Mvc;

namespace kalaatmacwebapp.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
