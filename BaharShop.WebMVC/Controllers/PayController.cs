using BaharShop.Application.Features.Finances.Commands.Requests;
using BaharShop.Application.Services.Carts;
using BaharShop.WebMVC.Utilities;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BaharShop.WebMVC.Controllers
{
    [Authorize("Customer")]
    public class PayController : Controller
    {
        private readonly IMediator _mediator;
        private readonly ICartServices _cartServices;
        private readonly CookiesManeger _cookiesManeger;

        public PayController(IMediator mediator, ICartServices cartServices)
        {
            _mediator = mediator;
            _cartServices = cartServices;
            _cookiesManeger = new CookiesManeger();
        }

        public async Task<IActionResult> Index()
        {
            int? userId = ClaimUtility.GetUserId(User);
            var myCart = await _cartServices.GetMyCart(_cookiesManeger.GetBrowserId(HttpContext), userId);

            if(myCart.Data.SumAmount > 0)
            {
                CreateRequestPayCommand command = new CreateRequestPayCommand
                {
                    UserId = userId.Value,
                    Amount = myCart.Data.SumAmount
                };

                var result = await _mediator.Send(command);
            }
            else
            {
                return RedirectToAction("Index", "Cart");
            }

            return View();
        }
    }
}
