using MediatR;
using BaharShop.Application.DTOs.Products;

namespace BaharShop.Application.Features.Products.Queries.Requests
{
    public class GetProductQuery : IRequest<ProductDTO>
    {
        public int Id { get; set; }
    }
}