using Microsoft.AspNetCore.Mvc;

namespace kalaatmacwebapp.Controllers
{
    public class GalleryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
