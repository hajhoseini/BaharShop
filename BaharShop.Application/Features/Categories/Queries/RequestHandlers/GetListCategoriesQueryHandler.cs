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
			var categoryList = await _categoryReader.GetListByParentId(request.parentId);

			var categoryDTOList = categoryList
									.Where(c => c.ParentId == null)
									.Select(c => new CategoryDTO()
									{
										Id = c.Id,
										Name = c.Name,
										ParentId = c.ParentId,
										HasChild = c.Children.Count() > 0 ? true : false,
									})
									.ToList();

			return categoryDTOList;
		}
	}
}