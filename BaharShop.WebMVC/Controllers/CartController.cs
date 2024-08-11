using BaharShop.Application.Services.Carts;
using BaharShop.WebMVC.Utilities;
using Microsoft.AspNetCore.Mvc;

namespace BaharShop.WebMVC.Controllers
{
    public class CartController : Controller
    {
        private readonly ICartServices _cartServices;
        private readonly CookiesManeger _cookiesManeger;

        public CartController(ICartServices cartServices)
        {
            _cartServices = cartServices;
            _cookiesManeger = new CookiesManeger();
        }

        public async Task<IActionResult> Index()
        {
            var userId = ClaimUtility.GetUserId(User);
            var myCart = await _cartServices.GetMyCart(_cookiesManeger.GetBrowserId(HttpContext), userId);

            return View(myCart.Data);
        }

        public async Task<IActionResult> AddToCart(int productId)
        {
            var result = await _cartServices.AddToCart(productId, _cookiesManeger.GetBrowserId(HttpContext));

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Remove(int productId)
        {
            await _cartServices.RemoveFromCart(_cookiesManeger.GetBrowserId(HttpContext));
            return RedirectToAction("Index");

        }

        public async Task<IActionResult> Increase(int cartItemId)
        {
            var result = await _cartServices.Increase(cartItemId);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Decrease(int cartItemId)
        {
            var result = await _cartServices.Decrease(cartItemId);
            return RedirectToAction("Index");
        }        
    }
}
