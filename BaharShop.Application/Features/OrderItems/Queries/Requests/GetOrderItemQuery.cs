using MediatR;
using BaharShop.Application.DTOs.OrderItems;

namespace BaharShop.Application.Features.OrderItems.Queries.Requests
{
    public class GetOrderItemQuery : IRequest<OrderItemDTO>
    {
        public int Id { get; set; }
    }
}