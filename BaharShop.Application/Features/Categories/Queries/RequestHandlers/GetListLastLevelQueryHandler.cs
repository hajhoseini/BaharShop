using MediatR;
using AutoMapper;
using BaharShop.Domain.IReaders.Categories;
using BaharShop.Application.DTOs.Categories;
using BaharShop.Application.Features.Categories.Queries.Requests;

namespace BaharShop.Application.Features.Categories.Queries.RequestHandlers
{
	public class GetListLastLevelQueryHandler : IRequestHandler<GetListLastLevelQuery, List<CategoryDTO>>
	{
		private readonly IMapper _mapper;
		private readonly ICategoryReader _categoryReader;

		public GetListLastLevelQueryHandler(IMapper mapper, ICategoryReader categoryReader)
		{
			_mapper = mapper;
			_categoryReader = categoryReader;
		}

		public async Task<List<CategoryDTO>> Handle(GetListLastLevelQuery request, CancellationToken cancellationToken)
		{
			var categoryList = await _categoryReader.GetListLastLevel();
			return _mapper.Map<List<CategoryDTO>>(categoryList);
		}
	}
}