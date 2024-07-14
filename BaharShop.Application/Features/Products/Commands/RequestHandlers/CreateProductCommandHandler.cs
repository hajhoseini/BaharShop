using MediatR;
using AutoMapper;
using BaharShop.Common;
using BaharShop.Domain.IRepositories;
using BaharShop.Domain.Entities.Products;
using BaharShop.Application.Features.Products.Commands.Requests;

namespace BaharShop.Application.Features.Products.Commands.RequestHandlers
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, ResultDTO>
	{
		private readonly IGenericRepository<Product> _genericRepository;
		private readonly IMapper _mapper;
        private readonly IGenericRepository<ProductFeature> _productFeatureRepository;

        public CreateProductCommandHandler(IGenericRepository<Product> genericRepository, IMapper mapper, IGenericRepository<ProductFeature> productFeatureRepository)
		{
			_genericRepository = genericRepository;
			_mapper = mapper;
            _productFeatureRepository = productFeatureRepository;
        }

        public async Task<ResultDTO> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var entity = _mapper.Map<Product>(request.productDTO);
                var result = await _genericRepository.Create(entity);

                List<ProductFeature> productFeatures = new List<ProductFeature>();
                foreach (var item in request.productDTO.Features)
                {
                    productFeatures.Add(new ProductFeature
                    {
                        DisplayName = item.DisplayName,
                        Value = item.Value,
                        Product = entity,
                    });
                }
                var result2 = await _productFeatureRepository.AddRange(productFeatures);

                result.Message = "محصول با موفقیت ثبت شد";
                return result;
            }
            catch (Exception ex)
            {
                return new ResultDTO
                {
                    IsSuccess = false,
                    Message = "خطا رخ داد ",
                };
            }
        }
    }
}
