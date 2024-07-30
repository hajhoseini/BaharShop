using BaharShop.Application.DTOs.HomePages.Sliders;
using BaharShop.Application.Features.HomePages.Sliders.Commands.Requests;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BaharShop.WebMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SliderController : Controller
    {
        private readonly IMediator _mediator;

        public SliderController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(IFormFile file, string link)
        {
            CreateSliderCommand command = new CreateSliderCommand { File = file, Link = link };
            var slider = await _mediator.Send(command);
            return View();
        }
    }
}
