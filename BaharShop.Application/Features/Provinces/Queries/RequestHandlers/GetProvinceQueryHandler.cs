using MediatR;
using AutoMapper;
using BaharShop.Domain.IReaders.Provinces;
using BaharShop.Application.DTOs.Provinces;
using BaharShop.Application.Features.Provinces.Queries.Requests;

namespace BaharShop.Application.Features.Provinces.Queries.RequestHandlers
{
    public class GetProvinceQueryHandler : IRequestHandler<GetProvinceQuery, ProvinceDTO>
    {
        private readonly IMapper _mapper;
        private readonly IProvinceReader _provinceReader;

        public GetProvinceQueryHandler(IMapper mapper, IProvinceReader provinceReader)
        {
            _mapper = mapper;
            _provinceReader = provinceReader;
        }

        public async Task<ProvinceDTO> Handle(GetProvinceQuery request, CancellationToken cancellationToken)
        {
            var provinceEntity = await _provinceReader.GetById(request.Id);
            return _mapper.Map<ProvinceDTO>(provinceEntity);
        }
    }
}
