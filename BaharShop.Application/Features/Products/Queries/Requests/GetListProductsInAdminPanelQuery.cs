using MediatR;
using BaharShop.Application.DTOs.Products;
using BaharShop.Common;

namespace BaharShop.Application.Features.Products.Queries.Requests
{
    public class GetListProductsInAdminPanelQuery : IRequest<ResultDTO<ProductsListAdminPanelDTO>>
    {
        public int CurrentPage { get; set; }

        public int PageSize { get; set; }
    }
}