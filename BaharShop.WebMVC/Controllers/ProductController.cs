using BaharShop.Application.Features.Products.Queries.Requests;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BaharShop.WebMVC.Controllers
{
    public class ProductController : Controller
    {
        private readonly IMediator _mediator;

        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IActionResult> Index(int? categoryId = null, int page = 1)
        {
            GetListProductsSiteQuery query = new GetListProductsSiteQuery { CurrentPage = page, CategoryId = categoryId };
            var result = await _mediator.Send(query);
            return View(result.Data);
        }

        public async Task<IActionResult> Detail(int id)
        {
            GetProductDetailQuery query = new GetProductDetailQuery { Id = id };
            var result = await _mediator.Send(query);
            return View(result.Data);
        }
    }
}
