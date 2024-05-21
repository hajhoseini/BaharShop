using MediatR;
using BaharShop.Application.DTOs.Products;

namespace BaharShop.Application.Features.Products.Queries.Requests
{
    public class GetListProductsQuery : IRequest<List<ProductDTO>>
    {

    }
}