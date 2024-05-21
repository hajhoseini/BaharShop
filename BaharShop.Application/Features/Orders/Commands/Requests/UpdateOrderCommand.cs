using BaharShop.Application.DTOs.Orders;
using BaharShop.Common;
using MediatR;

namespace BaharShop.Application.Features.Orders.Commands.Requests
{
    public class UpdateOrderCommand : IRequest<ResultDTO>
	{
        public OrderDTO OrderDTO { get; set; }
    }
}
