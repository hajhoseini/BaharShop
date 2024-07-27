using BaharShop.Application.Features.MenuItems.Queries.Requests;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BaharShop.WebMVC.ViewComponents
{
    public class Search : ViewComponent
    {
        private readonly IMediator _mediator;

        public Search(IMediator mediator)
        {
            _mediator = mediator;
        }

        public IViewComponentResult Invoke()
        {
            GetListMenuItemsQuery query = new GetListMenuItemsQuery();
            var result = _mediator.Send(query).GetAwaiter().GetResult();

            return View(viewName: "Search", result.Data);
        }
    }
}
