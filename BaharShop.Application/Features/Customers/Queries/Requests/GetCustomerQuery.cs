using MediatR;
using BaharShop.Application.DTOs.Customers;

namespace BaharShop.Application.Features.Customers.Queries.Requests
{
    public class GetCustomerQuery : IRequest<CustomerDTO>
    {
        public int Id { get; set; }
    }
}