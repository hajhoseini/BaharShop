using BaharShop.Application.DTOs.Products;
using BaharShop.Application.Features.Categories.Queries.Requests;
using BaharShop.Application.Features.Products.Commands.Requests;
using BaharShop.Application.Features.Products.Queries.Requests;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

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

        public async Task<IActionResult> Index(int Page = 1, int PageSize = 5)
        {
            GetListProductsInAdminPanelQuery query = new GetListProductsInAdminPanelQuery()
            {
                CurrentPage = Page,
                PageSize = PageSize
            };
            var productList = await _mediator.Send(query);

            return View(productList.Data);
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
        public async Task<IActionResult> Create([FromForm] ProductDTO request, [FromForm] List<IFormFile> images, [FromForm] List<ProductFeatureDTO> features)
        {
            if (!ModelState.IsValid)
            {
                var errors = ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage).ToList();
                return Json(new { IsSuccess = false, Message = "Validation failed", Errors = errors });
            }

            request.Images = images;
            request.Features = features;

            var command = new CreateProductCommand { productDTO = request };
            var result = await _mediator.Send(command);

            return Json(result);
        }



        public async Task<IActionResult> Detail(int Id)
        {
            GetProductQuery query = new GetProductQuery() { Id = Id};
            var result = await _mediator.Send(query);

            return View(result);
        }
    }
}