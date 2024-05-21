using MediatR;
using BaharShop.Application.DTOs.OrderItems;

namespace BaharShop.Application.Features.OrderItems.Queries.Requests
{
    public class GetListOrderItemsQuery : IRequest<List<OrderItemDTO>>
    {

    }
}