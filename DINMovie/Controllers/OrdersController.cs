using Microsoft.AspNetCore.Mvc;

namespace DINMovie.Controllers
{
    public class OrdersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
