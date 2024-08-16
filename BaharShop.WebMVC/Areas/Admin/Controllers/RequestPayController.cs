using BaharShop.Application.Features.Finances.Queries.Requests;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BaharShop.WebMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class RequestPayController : Controller
    {
        private readonly IMediator _mediator;

        public RequestPayController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IActionResult> Index()
        {
            GetListRequestPayForAdminQuery query = new GetListRequestPayForAdminQuery();
            var result = await _mediator.Send(query);

            return View(result.Data);
        }
    }
}