using MediatR;
using AutoMapper;
using BaharShop.Domain.IReaders.Cities;
using BaharShop.Application.DTOs.Cities;
using BaharShop.Application.Features.Cities.Queries.Requests;

namespace BaharShop.Application.Features.Cities.Queries.RequestHandlers
{
    public class GetListCitiesQueryHandler : IRequestHandler<GetListCitiesQuery, List<CityDTO>>
	{
		private readonly IMapper _mapper;
		private readonly ICityReader _cityReader;

		public GetListCitiesQueryHandler(IMapper mapper, ICityReader cityReader)
		{
			_mapper = mapper;
			_cityReader = cityReader;
		}

		public async Task<List<CityDTO>> Handle(GetListCitiesQuery request, CancellationToken cancellationToken)
		{
			var all = await _cityReader.GetList(null, null);
			return _mapper.Map<List<CityDTO>>(all.ToList());
		}
	}
}