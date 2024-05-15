using MediatR;
using BaharShop.Common;

namespace BaharShop.Application.Features.Customers.Commands.Requests
{
    public class DeleteCustomerCommand : IRequest<ResultDTO>
	{
		public int Id { get; set; }
	}
}
