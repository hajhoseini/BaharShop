using BaharShop.Application.DTOs.HomePages;
using BaharShop.Application.Features.HomePage.Commands.Requests;
using BaharShop.Common.Enums;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BaharShop.WebMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
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
            if (file == null || file.Length == 0)
            {
                ViewBag.ErrorMessage = "لطفاً یک فایل تصویر انتخاب کنید.";
                return View();
            }

            if (string.IsNullOrWhiteSpace(link))
            {
                ViewBag.ErrorMessage = "لطفاً آدرس لینک را وارد کنید.";
                return View();
            }

            var command = new CreateHomePageImageCommand
            {
                createHomePageImageDTO = new CreateHomePageImageDTO
                {
                    File = file,
                    Link = link,
                    ImageLocation = imageLocation,
                }
            };

            var result = await _mediator.Send(command);

            if (result.IsSuccess)
            {
                ViewBag.Message = "تصویر با موفقیت آپلود شد.";
            }
            else
            {
                ViewBag.ErrorMessage = "خطایی در آپلود تصویر رخ داد. لطفاً مجدداً تلاش کنید.";
            }

            return View();
        }
    }
}
