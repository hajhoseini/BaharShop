using MediatR;
using AutoMapper;
using BaharShop.Common;
using BaharShop.Domain.IRepositories;
using BaharShop.Domain.Entities.Products;
using BaharShop.Application.Features.Products.Commands.Requests;

namespace BaharShop.Application.Features.Products.Commands.RequestHandlers
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand, ResultDTO>
	{
		private readonly IGenericRepository<Product> _genericRepository;
		private readonly IMapper _mapper;

		public UpdateProductCommandHandler(IGenericRepository<Product> genericRepository, IMapper mapper)
		{
			_genericRepository = genericRepository;
			_mapper = mapper;
		}

        public async Task<ResultDTO> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<Product>(request.productDTO);
            var result = await _genericRepository.Update(entity);
            return result;
        }
    }
}
