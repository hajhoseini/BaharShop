using MediatR;
using BaharShop.Common;

namespace BaharShop.Application.Features.Addresses.Commands.Requests
{
    public class DeleteAddressCommand : IRequest<ResultDTO>
	{
		public int Id { get; set; }
	}
}
