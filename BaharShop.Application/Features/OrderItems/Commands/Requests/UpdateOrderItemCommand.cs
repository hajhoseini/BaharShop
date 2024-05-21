using BaharShop.Application.DTOs.OrderItems;
using BaharShop.Common;
using MediatR;

namespace BaharShop.Application.Features.OrderItems.Commands.Requests
{
    public class UpdateOrderItemCommand : IRequest<ResultDTO>
	{
        public OrderItemDTO orderItemDTO { get; set; }
    }
}
