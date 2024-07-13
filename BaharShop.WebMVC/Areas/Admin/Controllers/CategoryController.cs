using BaharShop.Application.DTOs.Categories;
using BaharShop.Application.Features.Categories.Commands.Requests;
using BaharShop.Application.Features.Categories.Queries.Requests;
using BaharShop.WebMVC.Areas.Admin.Models.CategoryViewModels;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BaharShop.WebMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly IMediator _mediator;

        public CategoryController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IActionResult> Index(int? parentId)
        {
            GetListCategoriesQuery query = new GetListCategoriesQuery() 
            { 
                parentId = parentId 
            };
            var result = await _mediator.Send(query);

            List<CategoryViewModel> list = new List<CategoryViewModel>();

            if(parentId != null && parentId > 0)
            {
                GetCategoryQuery parentQuery = new GetCategoryQuery()
                { 
                    Id = parentId == null ? default(int) : parentId.Value 
                };
                var parent = await _mediator.Send(parentQuery);

                foreach (var category in result)
                {
                    list.Add(
                                new CategoryViewModel()
                                {
                                    Id = category.Id,
                                    Name = category.Name,
                                    HasChild = category.HasChild,
                                    ParentId = category.ParentId,
                                    ParentName = parent.Name
                                }
                            );
                }
            }
            else
            {
                foreach (var category in result)
                {
                    list.Add(
                                new CategoryViewModel()
                                {
                                    Id = category.Id,
                                    Name = category.Name,
                                    HasChild = category.HasChild,
                                    ParentId = category.ParentId,
                                    ParentName = "-"
                                }
                            );
                }
            }

            return View(list);
        }

        [HttpGet]
        public IActionResult Create(long? parentId)
        {
            ViewBag.parentId = parentId;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(int? parentId, string name)
        {
            CreateCategoryCommand command = new CreateCategoryCommand()
            {
                categoryDTO = new CategoryDTO()
                {
                    Name = name,
                    ParentId = parentId
                }
            };
            var result = await _mediator.Send(command);
            return Json(result);
        }
    }
}