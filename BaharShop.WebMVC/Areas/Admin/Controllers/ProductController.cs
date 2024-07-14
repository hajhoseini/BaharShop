using BaharShop.Application.DTOs.Products;
using BaharShop.Application.Features.Categories.Queries.Requests;
using BaharShop.Application.Features.Products.Commands.Requests;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BaharShop.WebMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly IMediator _mediator;

        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            GetListHieararchyCategoriesQuery query = new GetListHieararchyCategoriesQuery();
            var categoryList = await _mediator.Send(query);

            ViewBag.Categories = new SelectList(categoryList, "Id", "Name");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(ProductDTO request, List<ProductFeatureDTO> Features)
        {
            request.Features = Features;
            CreateProductCommand command = new CreateProductCommand() { productDTO = request };
            var result = await _mediator.Send(command);

            return Json(result);
        }
    }
}