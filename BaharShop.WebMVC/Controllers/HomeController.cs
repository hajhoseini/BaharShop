using BaharShop.Application.Features.HomePages.Sliders.Queries.Requests;
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
            GetListSlidersQuery query = new GetListSlidersQuery();
            var sliders = await _mediator.Send(query);

            HomePageViewModel homePage = new HomePageViewModel
            {
                Sliders = sliders,
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