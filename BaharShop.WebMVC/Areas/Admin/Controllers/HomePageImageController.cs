using BaharShop.Application.DTOs.HomePages;
using BaharShop.Application.Features.HomePage.Commands.Requests;
using BaharShop.Common.Enums;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BaharShop.WebMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomePageImageController : Controller
    {
        private readonly IMediator _mediator;

        public HomePageImageController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IActionResult> Index()
        {
            return View();
        }

        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(IFormFile file, string link, ImageLocationEnum imageLocation)
        {
            CreateHomePageImageCommand command = new CreateHomePageImageCommand
            {
                createHomePageImageDTO = new CreateHomePageImageDTO
                {
                    File = file,
                    Link = link,
                    ImageLocation = imageLocation,
                }
            };
            var result = await _mediator.Send(command);

            return View();
        }
    }
}
