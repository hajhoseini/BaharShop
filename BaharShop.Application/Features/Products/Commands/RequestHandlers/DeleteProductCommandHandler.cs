using MediatR;
using BaharShop.Common;
using BaharShop.Domain.IRepositories;
using BaharShop.Domain.Entities.Products;
using BaharShop.Application.Features.Products.Commands.Requests;

namespace BaharShop.Application.Features.Products.Commands.RequestHandlers
{
    public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommand, ResultDTO>
	{
		private readonly IGenericRepository<Product> _genericRepository;

		public DeleteProductCommandHandler(IGenericRepository<Product> genericRepository)
		{
			_genericRepository = genericRepository;
		}

        public async Task<ResultDTO> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
            Product product = new Product { Id = request.Id };
            var result = await _genericRepository.Delete(product);
            return result;
        }
    }
}
