using MediatR;
using BaharShop.Common;
using BaharShop.Application.DTOs.Customers;

namespace BaharShop.Application.Features.Customers.Commands.Requests
{
    public class CreateCustomerCommand : IRequest<ResultDTO>
	{
		public CustomerDTO customerDTO { get; set; }
	}
}
