using MediatR;
using BaharShop.Application.DTOs.Products;
using BaharShop.Common;

namespace BaharShop.Application.Features.Products.Queries.Requests
{
    public class GetProductDetailQuery : IRequest<ResultDTO<ProductDetailSiteDTO>>
    {
        public int Id { get; set; }
    }
}