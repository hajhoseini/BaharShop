using MediatR;
using AutoMapper;
using BaharShop.Application.Features.HomePages.Sliders.Queries.Requests;
using BaharShop.Application.DTOs.HomePages.Sliders;
using BaharShop.Domain.IReaders.HomePages.Sliders;

namespace BaharShop.Application.Features.HomePages.Sliders.Queries.RequestHandlers
{
    public class GetListSlidersQueryHandler : IRequestHandler<GetListSlidersQuery, List<SliderDTO>>
	{
		private readonly IMapper _mapper;
		private readonly ISliderReader _sliderReader;

		public GetListSlidersQueryHandler(IMapper mapper, ISliderReader sliderReader)
		{
			_mapper = mapper;
			_sliderReader = sliderReader;
		}

		public async Task<List<SliderDTO>> Handle(GetListSlidersQuery request, CancellationToken cancellationToken)
		{
			var all = await _sliderReader.GetList(null, null);
			return _mapper.Map<List<SliderDTO>>(all.ToList());
		}
	}
}