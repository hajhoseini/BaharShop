using MediatR;
using BaharShop.Common;
using BaharShop.Application.DTOs.OrderItems;

namespace BaharShop.Application.Features.OrderItems.Commands.Requests
{
    public class CreateOrderItemCommand : IRequest<ResultDTO>
	{
		public OrderItemDTO orderItemDTO { get; set; }
	}
}
