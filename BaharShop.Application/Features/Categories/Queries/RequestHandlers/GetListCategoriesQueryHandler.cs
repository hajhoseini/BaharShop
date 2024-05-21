using MediatR;
using AutoMapper;
using BaharShop.Domain.IReaders.Categories;
using BaharShop.Application.DTOs.Categories;
using BaharShop.Application.Features.Categories.Queries.Requests;
using BaharShop.Domain.Entities.Categories;

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
			var all = await _categoryReader.GetList();
			var categoryList = all.ToList();

			List<Category> hierarchy = new List<Category>();

			hierarchy = categoryList
							.Where(c => c.ParentId == null)
							.Select(c => new Category()
							{
								Id = c.Id,
								Name = c.Name,
								ParentId = c.ParentId,
								Children = GetChildren(categoryList, c.Id)
							})
							.ToList();

			HieararchyWalk(hierarchy);

			return _mapper.Map<List<CategoryDTO>>(hierarchy);
		}

		private List<Category> GetChildren(List<Category> categoryList, int parentId)
		{
			return categoryList
					.Where(c => c.ParentId == parentId)
					.Select(c => new Category
					{
						Id = c.Id,
						Name = c.Name,
						ParentId = c.ParentId,
						Children = GetChildren(categoryList, c.Id)
					})
					.ToList();
		}

		private void HieararchyWalk(List<Category> hierarchy)
		{
			if (hierarchy != null)
			{
				foreach (var item in hierarchy)
				{
					HieararchyWalk(item.Children);
				}
			}
		}
	}
}