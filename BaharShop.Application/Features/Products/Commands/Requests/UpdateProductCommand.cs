using BaharShop.Application.DTOs.Products;
using BaharShop.Common;
using MediatR;

namespace BaharShop.Application.Features.Products.Commands.Requests
{
    public class UpdateProductCommand : IRequest<ResultDTO>
	{
        public ProductDTO productDTO { get; set; }
    }
}
