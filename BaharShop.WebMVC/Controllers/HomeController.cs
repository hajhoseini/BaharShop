using BaharShop.Application.DTOs.HomePages;
using BaharShop.Application.Features.HomePage.Queries.Requests;
using BaharShop.Common.Enums;
using BaharShop.WebMVC.Models;
using BaharShop.WebMVC.Models.ViewModels.HomePages;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BaharShop.WebMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMediator _mediator;

        public HomeController(ILogger<HomeController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        public async Task<IActionResult> Index()
        {
            GetListHomePageImagesQuery query = new GetListHomePageImagesQuery();
            var homePageImages = await _mediator.Send(query);

            List<HomePageImageDTO> list = homePageImages.Data;

            HomePageViewModel homePage = new HomePageViewModel()
            {
                Sliders = list.Where(p => p.ImageLocation == ImageLocationEnum.Slider).ToList(),
                PageImages = list,
                //Camera = _productFacad.GetProductForSiteService.Execute(Ordering.theNewest
            };

            return View(homePage);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}