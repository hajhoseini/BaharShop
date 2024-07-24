using MediatR;
using AutoMapper;
using BaharShop.Common;
using BaharShop.Domain.IRepositories;
using BaharShop.Domain.Entities.Categories;
using BaharShop.Application.Features.Categories.Commands.Requests;

namespace BaharShop.Application.Features.Categories.Commands.RequestHandlers
{
    public class CreateCategoryCommandHandler : IRequestHandler<CreateCategoryCommand, ResultDTO>
	{
		private readonly IGenericRepository<Category> _genericRepository;
		private readonly IMapper _mapper;

		public CreateCategoryCommandHandler(IGenericRepository<Category> genericRepository, IMapper mapper)
		{
			_genericRepository = genericRepository;
			_mapper = mapper;
		}

        public async Task<ResultDTO> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
        {
            if(request.categoryDTO.Name == null)
            {
                return new ResultDTO
                {
                    IsSuccess = false,
                    Message = "نام دسته بندی اجباری است",
                };
            }

            var entity = _mapper.Map<Category>(request.categoryDTO);
            var result = await _genericRepository.Create(entity);
            return result;
        }
    }
}
