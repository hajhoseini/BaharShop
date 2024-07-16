using MediatR;
using AutoMapper;
using BaharShop.Common;
using BaharShop.Domain.IRepositories;
using BaharShop.Domain.Entities.Products;
using BaharShop.Application.Features.Products.Commands.Requests;
using Microsoft.AspNetCore.Hosting;

namespace BaharShop.Application.Features.Products.Commands.RequestHandlers
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, ResultDTO>
	{
		private readonly IGenericRepository<Product> _genericRepository;
		private readonly IMapper _mapper;
        private readonly IGenericRepository<ProductFeature> _productFeatureRepository;
        private readonly IHostingEnvironment _environment;
        private readonly IGenericRepository<ProductImage> _productImageRepository;

        public CreateProductCommandHandler(IGenericRepository<Product> genericRepository, IMapper mapper, 
                                            IGenericRepository<ProductFeature> productFeatureRepository,
                                            IHostingEnvironment environment,
                                            IGenericRepository<ProductImage> productImageRepository)
		{
			_genericRepository = genericRepository;
			_mapper = mapper;
            _productFeatureRepository = productFeatureRepository;
            _environment = environment;
            _productImageRepository = productImageRepository;
        }

        public async Task<ResultDTO> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var entity = _mapper.Map<Product>(request.productDTO);
                var result = await _genericRepository.Create(entity);

                if(!result.IsSuccess)
                {
                    return new ResultDTO
                    {
                        IsSuccess = false,
                        Message = "خطا در ثبت محصول رخ داده است",
                    };
                }

                #region ProductFeature

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
                var resultFeatures = await _productFeatureRepository.AddRange(productFeatures);
                if (!resultFeatures.IsSuccess)
                {
                    return new ResultDTO
                    {
                        IsSuccess = false,
                        Message = "خطا در ثبت ویژگی های محصول رخ داده است",
                    };
                }

                #endregion

                #region ProductImage

                Common.File file = new Common.File(_environment);

                List<ProductImage> productImages = new List<ProductImage>();
                foreach (var item in request.productDTO.Images)
                {
                    var uploadedResult = file.UploadFile(item);
                    productImages.Add(new ProductImage
                    {
                        Product = entity,
                        Src = uploadedResult.FileNameAddress,
                    });
                }

                var resultImages = await _productImageRepository.AddRange(productImages);
                if (!resultImages.IsSuccess)
                {
                    return new ResultDTO
                    {
                        IsSuccess = false,
                        Message = "خطا در ثبت تصاویر محصول رخ داده است",
                    };
                }

                #endregion

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
