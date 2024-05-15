using BaharShop.Application.DTOs.Customers;
using BaharShop.Common;
using MediatR;

namespace BaharShop.Application.Features.Customers.Commands.Requests
{
    public class UpdateCustomerCommand : IRequest<ResultDTO>
	{
        public CustomerDTO customerDTO { get; set; }
    }
}
