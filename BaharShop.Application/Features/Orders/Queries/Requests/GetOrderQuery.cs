using MediatR;
using BaharShop.Application.DTOs.Orders;

namespace BaharShop.Application.Features.Orders.Queries.Requests
{
    public class GetOrderQuery : IRequest<OrderDTO>
    {
        public int Id { get; set; }
    }
}