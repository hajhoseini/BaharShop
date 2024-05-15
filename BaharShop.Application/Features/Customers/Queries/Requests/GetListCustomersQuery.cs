using MediatR;
using BaharShop.Application.DTOs.Customers;

namespace BaharShop.Application.Features.Customers.Queries.Requests
{
    public class GetListCustomersQuery : IRequest<List<CustomerDTO>>
    {

    }
}