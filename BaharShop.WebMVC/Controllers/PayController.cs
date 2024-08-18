using BaharShop.Application.DTOs.Orders;
using BaharShop.Application.Features.Finances.Commands.Requests;
using BaharShop.Application.Features.Finances.Queries.Requests;
using BaharShop.Application.Services.Carts;
using BaharShop.Application.Services.Orders;
//using BaharShop.Domain.Entities.Finances;
using BaharShop.WebMVC.Utilities;
using Dto.Payment;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ZarinPal.Class;

namespace BaharShop.WebMVC.Controllers
{
    [Authorize("Customer")]
    public class PayController : Controller
    {
        private readonly IMediator _mediator;
        private readonly ICartServices _cartServices;
        private readonly CookiesManeger _cookiesManeger;
        private readonly Payment _payment;
        //private readonly Authority _authority;
        //private readonly Transactions _transactions;
        private readonly IOrderServices _orderServices;

        public PayController(IMediator mediator, ICartServices cartServices, IOrderServices orderServices)
        {
            _mediator = mediator;
            _cartServices = cartServices;
            _cookiesManeger = new CookiesManeger();

            var expose = new Expose();
            _payment = expose.CreatePayment();
            //_authority = expose.CreateAuthority();
            //_transactions = expose.CreateTransactions();
            _orderServices = orderServices;
        }

        public async Task<IActionResult> Index()
        {
            int? userId = ClaimUtility.GetUserId(User);
            var myCart = await _cartServices.GetMyCart(_cookiesManeger.GetBrowserId(HttpContext), userId);

            if(myCart.Data.SumAmount > 0)
            {
                RequestPayCommand command = new RequestPayCommand
                {
                    UserId = userId.Value,
                    Amount = myCart.Data.SumAmount
                };

                var requestPay = await _mediator.Send(command);

                //Send to payment
                var result = await _payment.Request(
                                                new DtoRequest()
                                                {
                                                    Mobile = requestPay.Data.MobileNumber,
                                                    CallbackUrl = $"https://localhost:44376/Pay/Verify?guid={requestPay.Data.Guid}",
                                                    Description = "پرداخت فاکتور شماره:" + requestPay.Data.PayId,
                                                    Email = requestPay.Data.Email,
                                                    Amount = Decimal.ToInt32(requestPay.Data.Amount),
                                                    MerchantId = "XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX"
                                                }
                                                , ZarinPal.Class.Payment.Mode.sandbox);//sandbox for test

                return Redirect($"https://sandbox.zarinpal.com/pg/StartPay/{result.Authority}");
            }
            else
            {
                return RedirectToAction("Index", "Cart");
            }

            return View();
        }

        public async Task<IActionResult> Verify(Guid guid, string authority, string status)
        {
            GetPayQuery query = new GetPayQuery { Guid = guid };
            var requestPay = await _mediator.Send(query);

            var verification = await _payment.Verification(
                                                    new DtoVerification
                                                    {
                                                        Amount = Decimal.ToInt32(requestPay.Data.Amount),
                                                        MerchantId = "XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX",
                                                        Authority = authority
                                                    }
                                                    , Payment.Mode.sandbox);

            int? userId = ClaimUtility.GetUserId(User);
            var cart = await _cartServices.GetMyCart(_cookiesManeger.GetBrowserId(HttpContext), userId);

            //ZarinPalByRest();

            if (verification.Status == 100)
            {
                var orderResult = await _orderServices.CreateOrder(
                                                            new CreateOrderDTO
                                                            {
                                                                CartId = cart.Data.CartId,
                                                                UserId = userId.Value,
                                                                PayId = requestPay.Data.Id,
                                                                Authority = authority,
                                                                RefId = 0//?
                                                            });
                
                return RedirectToAction("Index", "Order");
            }
            else
            {

            }

            return View();
        }

        private void ZarinPalByRest()
        {
            //var client = new RestClient("https://www.zarinpal.com/pg/rest/WebGate/PaymentVerification.json");
            //client.Timeout = -1;
            //var request = new RestRequest(Method.POST);
            //request.AddHeader("Content-Type", "application/json");
            //request.AddParameter("application/json", $"{{\"MerchantID\" :\"{merchendId}\",\"Authority\":\"{Authority}\",\"Amount\":\"{10000}\"}}", ParameterType.RequestBody);
            //IRestResponse response = client.Execute(request);
            //VerificationPayResultDto verification = JsonConvert.DeserializeObject<VerificationPayResultDto>(response.Content);
        }
    }
}
