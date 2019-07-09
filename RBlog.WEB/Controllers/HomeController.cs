
using Microsoft.AspNetCore.Mvc;

namespace RBlog.WEB.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
