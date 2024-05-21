using MediatR;
using BaharShop.Application.DTOs.Addresses;

namespace BaharShop.Application.Features.Addresses.Queries.Requests
{
    public class GetListAddressesQuery : IRequest<List<AddressDTO>>
    {

    }
}