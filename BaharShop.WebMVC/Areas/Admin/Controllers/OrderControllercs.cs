using BaharShop.Application.Services.Orders;
using BaharShop.Common.Enums;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BaharShop.WebMVC.Areas.Admin.Controllers
{
    [Area("admin")]
    [Authorize(Roles = "Admin,Operator")]
    public class OrderController : Controller
    {
        private readonly IOrderServices _orderServices;

        public OrderController(IOrderServices orderServices)
        {
            _orderServices = orderServices;
        }

        public IActionResult Index(OrderState orderState)
        {
            var orders = _orderServices.GetListOrdersForAdmin(orderState);
            return View(orders.Data);
        }
    }
}
