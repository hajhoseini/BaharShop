using MediatR;
using AutoMapper;
using BaharShop.Domain.IReaders.Addresses;
using BaharShop.Application.DTOs.Addresses;
using BaharShop.Application.Features.Addresses.Queries.Requests;

namespace BaharShop.Application.Features.Addresses.Queries.RequestHandlers
{
    public class GetListAddressesQueryHandler : IRequestHandler<GetListAddressesQuery, List<AddressDTO>>
	{
		private readonly IMapper _mapper;
		private readonly IAddressReader _addressReader;

		public GetListAddressesQueryHandler(IMapper mapper, IAddressReader AddressReader)
		{
			_mapper = mapper;
			_addressReader = AddressReader;
		}

		public async Task<List<AddressDTO>> Handle(GetListAddressesQuery request, CancellationToken cancellationToken)
		{
			var all = await _addressReader.GetList(null, null);
			return _mapper.Map<List<AddressDTO>>(all.ToList());
		}
	}
}