using MediatR;
using AutoMapper;
using BaharShop.Domain.IReaders.Categories;
using BaharShop.Application.DTOs.Categories;
using BaharShop.Application.Features.Categories.Queries.Requests;

namespace BaharShop.Application.Features.Categories.Queries.RequestHandlers
{
    public class GetListCategoriesQueryHandler : IRequestHandler<GetListCategoriesQuery, List<CategoryDTO>>
	{
		private readonly IMapper _mapper;
		private readonly ICategoryReader _categoryReader;

		public GetListCategoriesQueryHandler(IMapper mapper, ICategoryReader categoryReader)
		{
			_mapper = mapper;
			_categoryReader = categoryReader;
		}

		public async Task<List<CategoryDTO>> Handle(GetListCategoriesQuery request, CancellationToken cancellationToken)
		{
			var all = await _categoryReader.GetList(null, null);
			return _mapper.Map<List<CategoryDTO>>(all.ToList());
		}
	}
}