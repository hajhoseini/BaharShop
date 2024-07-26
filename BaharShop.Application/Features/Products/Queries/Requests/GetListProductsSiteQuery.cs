using MediatR;
using BaharShop.Application.DTOs.Products;
using BaharShop.Common;

namespace BaharShop.Application.Features.Products.Queries.Requests
{
    public class GetListProductsSiteQuery : IRequest<ResultDTO<ResultProductsListSiteDTO>>
    {
        public int CurrentPage { get; set; }
    }
}