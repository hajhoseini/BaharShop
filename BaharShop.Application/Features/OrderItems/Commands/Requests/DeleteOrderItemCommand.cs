using MediatR;
using BaharShop.Common;

namespace BaharShop.Application.Features.OrderItems.Commands.Requests
{
    public class DeleteOrderItemCommand : IRequest<ResultDTO>
	{
		public int Id { get; set; }
	}
}
