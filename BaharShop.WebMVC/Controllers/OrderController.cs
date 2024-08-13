using Microsoft.AspNetCore.Mvc;

namespace BaharShop.WebMVC.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
