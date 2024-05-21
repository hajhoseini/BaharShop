using MediatR;
using BaharShop.Common;
using BaharShop.Domain.IRepositories;
using BaharShop.Domain.Entities.Categories;
using BaharShop.Application.Features.Categories.Commands.Requests;

namespace BaharShop.Application.Features.Categories.Commands.RequestHandlers
{
    public class DeleteCategoryCommandHandler : IRequestHandler<DeleteCategoryCommand, ResultDTO>
	{
		private readonly IGenericRepository<Category> _genericRepository;

		public DeleteCategoryCommandHandler(IGenericRepository<Category> genericRepository)
		{
			_genericRepository = genericRepository;
		}

        public async Task<ResultDTO> Handle(DeleteCategoryCommand request, CancellationToken cancellationToken)
        {
            Category category = new Category { Id = request.Id };
            var result = await _genericRepository.Delete(category);
            return result;
        }
    }
}
