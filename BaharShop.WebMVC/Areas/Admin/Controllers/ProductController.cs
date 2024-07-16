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
        public async Task<IActionResult> Create(ProductDTO request, List<ProductFeatureDTO> Features)
        {
            request.Features = Features;

            List<IFormFile> images = new List<IFormFile>();
            for (int i = 0; i < Request.Form.Files.Count; i++)
            {
                var file = Request.Form.Files[i];
                images.Add(file);
            }
            request.Images = images;

            CreateProductCommand command = new CreateProductCommand() { productDTO = request };
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