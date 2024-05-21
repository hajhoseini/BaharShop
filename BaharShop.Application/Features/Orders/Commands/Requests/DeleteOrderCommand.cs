using MediatR;
using BaharShop.Common;

namespace BaharShop.Application.Features.Orders.Commands.Requests
{
    public class DeleteOrderCommand : IRequest<ResultDTO>
	{
		public int Id { get; set; }
	}
}
