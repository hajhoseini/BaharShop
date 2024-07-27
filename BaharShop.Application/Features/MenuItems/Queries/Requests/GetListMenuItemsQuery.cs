using BaharShop.Application.DTOs.MenuItems;
using BaharShop.Common;
using MediatR;

namespace BaharShop.Application.Features.MenuItems.Queries.Requests
{
    public class GetListMenuItemsQuery : IRequest<ResultDTO<List<MenuItemDTO>>>
    {
    }
}
