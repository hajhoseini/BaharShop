using MediatR;
using BaharShop.Application.DTOs.Addresses;

namespace BaharShop.Application.Features.Addresses.Queries.Requests
{
    public class GetAddressQuery : IRequest<AddressDTO>
    {
        public int Id { get; set; }
    }
}