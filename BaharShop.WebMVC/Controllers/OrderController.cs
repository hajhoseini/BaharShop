using BaharShop.Application.Services.Orders;
using BaharShop.WebMVC.Utilities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BaharShop.WebMVC.Controllers
{
    [Authorize]
    public class OrderController : Controller
    {
        private readonly IOrderServices _orderServices;

        public OrderController(IOrderServices orderServices)
        {
            _orderServices = orderServices;
        }

        public IActionResult Index()
        {
            int userId = ClaimUtility.GetUserId(User).Value;
            var userOrders = _orderServices.GetUserOrders(userId);
            return View(userOrders.Data);
        }
    }
}
