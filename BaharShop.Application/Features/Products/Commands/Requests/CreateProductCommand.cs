using MediatR;
using BaharShop.Common;
using BaharShop.Application.DTOs.Products;

namespace BaharShop.Application.Features.Products.Commands.Requests
{
    public class CreateProductCommand : IRequest<ResultDTO>
	{
		public ProductDTO productDTO { get; set; }
	}
}
