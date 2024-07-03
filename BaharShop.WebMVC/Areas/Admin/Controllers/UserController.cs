using BaharShop.Application.Features.Users.Queries.Requests;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BaharShop.WebMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UserController : Controller
    {
        private readonly IMediator _mediator;

        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IActionResult> Index()
        {
            GetListUsersQuery query = new GetListUsersQuery();
            var result = await _mediator.Send(query);
            return View(result);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
    }
}
