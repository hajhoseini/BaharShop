using MediatR;
using AutoMapper;
using BaharShop.Domain.IReaders.Categories;
using BaharShop.Application.DTOs.Categories;
using BaharShop.Application.Features.Categories.Queries.Requests;

namespace BaharShop.Application.Features.Categories.Queries.RequestHandlers
{
    public class GetCategoryQueryHandler : IRequestHandler<GetCategoryQuery, CategoryDTO>
    {
        private readonly IMapper _mapper;
        private readonly ICategoryReader _categoryReader;

        public GetCategoryQueryHandler(IMapper mapper, ICategoryReader categoryReader)
        {
            _mapper = mapper;
            _categoryReader = categoryReader;
        }

        public async Task<CategoryDTO> Handle(GetCategoryQuery request, CancellationToken cancellationToken)
        {
            var categoryEntity = await _categoryReader.GetById(request.Id);
            return _mapper.Map<CategoryDTO>(categoryEntity);
        }
    }
}
