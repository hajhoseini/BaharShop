using BaharShop.Application.Services.Carts;
using BaharShop.WebMVC.Utilities;
using Microsoft.AspNetCore.Mvc;

namespace BaharShop.WebMVC.ViewComponents
{
    public class Cart : ViewComponent
    {
        private readonly ICartServices _cartServices;
        private readonly CookiesManeger _cookiesManeger;
        public Cart(ICartServices cartServices)
        {
            _cartServices = cartServices;
            _cookiesManeger = new CookiesManeger();
        }

        public IViewComponentResult Invoke()
        {
            var userId = ClaimUtility.GetUserId(HttpContext.User);
            var myCart = _cartServices.GetMyCart(_cookiesManeger.GetBrowserId(HttpContext), userId).GetAwaiter().GetResult();
            return View(viewName: "Cart", myCart.Data);
        }
    }
}