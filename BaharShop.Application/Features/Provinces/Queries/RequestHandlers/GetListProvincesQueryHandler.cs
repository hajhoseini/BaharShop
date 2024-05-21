using MediatR;
using AutoMapper;
using BaharShop.Domain.IReaders.Provinces;
using BaharShop.Application.DTOs.Provinces;
using BaharShop.Application.Features.Provinces.Queries.Requests;

namespace BaharShop.Application.Features.Provinces.Queries.RequestHandlers
{
    public class GetListProvincesQueryHandler : IRequestHandler<GetListProvincesQuery, List<ProvinceDTO>>
	{
		private readonly IMapper _mapper;
		private readonly IProvinceReader _provinceReader;

		public GetListProvincesQueryHandler(IMapper mapper, IProvinceReader provinceReader)
		{
			_mapper = mapper;
			_provinceReader = provinceReader;
		}

		public async Task<List<ProvinceDTO>> Handle(GetListProvincesQuery request, CancellationToken cancellationToken)
		{
			var all = await _provinceReader.GetList(null, null);
			return _mapper.Map<List<ProvinceDTO>>(all.ToList());
		}
	}
}