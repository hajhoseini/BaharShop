using MediatR;
using AutoMapper;
using BaharShop.Domain.IReaders.Cities;
using BaharShop.Application.DTOs.Cities;
using BaharShop.Application.Features.Cities.Queries.Requests;

namespace BaharShop.Application.Features.Cities.Queries.RequestHandlers
{
    public class GetCityQueryHandler : IRequestHandler<GetCityQuery, CityDTO>
    {
        private readonly IMapper _mapper;
        private readonly ICityReader _cityReader;

        public GetCityQueryHandler(IMapper mapper, ICityReader cityReader)
        {
            _mapper = mapper;
            _cityReader = cityReader;
        }

        public async Task<CityDTO> Handle(GetCityQuery request, CancellationToken cancellationToken)
        {
            var cityEntity = await _cityReader.GetById(request.Id);
            return _mapper.Map<CityDTO>(cityEntity);
        }
    }
}
