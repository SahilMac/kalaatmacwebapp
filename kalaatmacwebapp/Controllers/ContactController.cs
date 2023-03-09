using Microsoft.AspNetCore.Mvc;

namespace kalaatmacwebapp.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
