using MediatR;
using BaharShop.Application.Features.MenuItems.Queries.Requests;
using BaharShop.Application.DTOs.MenuItems;
using BaharShop.Common;
using BaharShop.Domain.IReaders.Categories;

namespace BaharShop.Application.Features.MenuItems.Queries.RequestHandlers
{
    public class GetListMenuItemsQueryHandler : IRequestHandler<GetListMenuItemsQuery, ResultDTO<List<MenuItemDTO>>>
    {
        private readonly ICategoryReader _categoryReader;

        public GetListMenuItemsQueryHandler(ICategoryReader categoryReader)
        {
            _categoryReader = categoryReader;
        }

        public async Task<ResultDTO<List<MenuItemDTO>>> Handle(GetListMenuItemsQuery request, CancellationToken cancellationToken)
        {
            var menuItems = await _categoryReader.GetListMenuItems();

            var category = menuItems.Select(p => new MenuItemDTO
                            {
                                CategotyId = p.Id,
                                Name = p.Name,
                                Children = p.Children.ToList().Select(child => new MenuItemDTO
                                {
                                    CategotyId = child.Id,
                                    Name = child.Name,
                                }).ToList(),
                            })
                            .ToList();

            return new ResultDTO<List<MenuItemDTO>>()
            {
                Data = category,
                IsSuccess = true,
            };
        }
    }
}
