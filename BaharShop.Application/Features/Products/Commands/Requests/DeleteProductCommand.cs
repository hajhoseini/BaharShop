using MediatR;
using BaharShop.Common;

namespace BaharShop.Application.Features.Products.Commands.Requests
{
    public class DeleteProductCommand : IRequest<ResultDTO>
	{
		public int Id { get; set; }
	}
}
