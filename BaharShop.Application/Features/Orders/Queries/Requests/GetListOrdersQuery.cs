using MediatR;
using BaharShop.Application.DTOs.Orders;

namespace BaharShop.Application.Features.Orders.Queries.Requests
{
    public class GetListOrdersQuery : IRequest<List<OrderDTO>>
    {

    }
}