using MediatR;
using BaharShop.Common;
using BaharShop.Application.DTOs.Addresses;

namespace BaharShop.Application.Features.Addresses.Commands.Requests
{
    public class CreateAddressCommand : IRequest<ResultDTO>
	{
		public AddressDTO addressDTO { get; set; }
	}
}
