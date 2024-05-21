using MediatR;
using AutoMapper;
using BaharShop.Common;
using BaharShop.Domain.IRepositories;
using BaharShop.Domain.Entities.Categories;
using BaharShop.Application.Features.Categories.Commands.Requests;

namespace BaharShop.Application.Features.Categories.Commands.RequestHandlers
{
    public class UpdateCategoryCommandHandler : IRequestHandler<UpdateCategoryCommand, ResultDTO>
	{
		private readonly IGenericRepository<Category> _genericRepository;
		private readonly IMapper _mapper;

		public UpdateCategoryCommandHandler(IGenericRepository<Category> genericRepository, IMapper mapper)
		{
			_genericRepository = genericRepository;
			_mapper = mapper;
		}

        public async Task<ResultDTO> Handle(UpdateCategoryCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<Category>(request.categoryDTO);
            var result = await _genericRepository.Update(entity);
            return result;
        }
    }
}
