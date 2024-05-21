using MediatR;
using AutoMapper;
using BaharShop.Domain.IReaders.Addresses;
using BaharShop.Application.DTOs.Addresses;
using BaharShop.Application.Features.Addresses.Queries.Requests;

namespace BaharShop.Application.Features.Addresses.Queries.RequestHandlers
{
    public class GetAddressQueryHandler : IRequestHandler<GetAddressQuery, AddressDTO>
    {
        private readonly IMapper _mapper;
        private readonly IAddressReader _addressReader;

        public GetAddressQueryHandler(IMapper mapper, IAddressReader AddressReader)
        {
            _mapper = mapper;
            _addressReader = AddressReader;
        }

        public async Task<AddressDTO> Handle(GetAddressQuery request, CancellationToken cancellationToken)
        {
            var addressEntity = await _addressReader.GetById(request.Id);
            return _mapper.Map<AddressDTO>(addressEntity);
        }
    }
}
