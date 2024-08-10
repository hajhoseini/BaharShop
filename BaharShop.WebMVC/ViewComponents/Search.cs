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

        public async Task<IViewComponentResult> InvokeAsync()
        {
            GetListMenuItemsQuery query = new GetListMenuItemsQuery();
            var result = await _mediator.Send(query);

            return View(viewName: "Search", result.Data);
        }
    }
}
