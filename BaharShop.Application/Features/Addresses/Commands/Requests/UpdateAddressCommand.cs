using BaharShop.Application.DTOs.Addresses;
using BaharShop.Common;
using MediatR;

namespace BaharShop.Application.Features.Addresses.Commands.Requests
{
    public class UpdateAddressCommand : IRequest<ResultDTO>
	{
        public AddressDTO addressDTO { get; set; }
    }
}
