using MediatR;
using BaharShop.Common;
using BaharShop.Application.DTOs.Orders;

namespace BaharShop.Application.Features.Orders.Commands.Requests
{
    public class CreateOrderCommand : IRequest<ResultDTO>
	{
		public OrderDTO orderDTO { get; set; }
	}
}
