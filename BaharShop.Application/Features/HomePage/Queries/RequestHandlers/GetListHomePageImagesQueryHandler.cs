using AutoMapper;
using BaharShop.Application.DTOs.HomePages;
using BaharShop.Application.Features.HomePage.Queries.Requests;
using BaharShop.Common;
using BaharShop.Domain.IReaders.HomePage;
using MediatR;

namespace BaharShop.Application.Features.HomePage.Queries.RequestHandlers
{
	public class GetListHomePageImagesQueryHandler : IRequestHandler<GetListHomePageImagesQuery, ResultDTO<List<HomePageImageDTO>>>
	{
		private readonly IMapper _mapper;
		private readonly IHomePageImageReader _homePageImageReader;

		public GetListHomePageImagesQueryHandler(IMapper mapper, IHomePageImageReader homePageImageReader)
		{
			_mapper = mapper;
			_homePageImageReader = homePageImageReader;
		}

		public async Task<ResultDTO<List<HomePageImageDTO>>> Handle(GetListHomePageImagesQuery request, CancellationToken cancellationToken)
		{
			var all = await _homePageImageReader.GetList(null, null);

			return new ResultDTO<List<HomePageImageDTO>>
			{
				Data = _mapper.Map<List<HomePageImageDTO>>(all.ToList()),
				IsSuccess = true
			};
		}
	}
}
