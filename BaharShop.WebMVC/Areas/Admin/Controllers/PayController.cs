using BaharShop.Application.Features.Finances.Queries.Requests;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BaharShop.WebMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin,Operator")]
    public class PayController : Controller
    {
        private readonly IMediator _mediator;

        public PayController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IActionResult> Index()
        {
            GetListPaysForAdminQuery query = new GetListPaysForAdminQuery();
            var result = await _mediator.Send(query);

            return View(result.Data);
        }
    }
}