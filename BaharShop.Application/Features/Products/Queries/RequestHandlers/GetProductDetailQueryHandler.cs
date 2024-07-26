using MediatR;
using AutoMapper;
using BaharShop.Domain.IReaders.Products;
using BaharShop.Application.DTOs.Products;
using BaharShop.Application.Features.Products.Queries.Requests;
using BaharShop.Common;

namespace BaharShop.Application.Features.Products.Queries.RequestHandlers
{
    public class GetProductDetailQueryHandler : IRequestHandler<GetProductDetailQuery, ResultDTO<ProductDetailSiteDTO>>
    {
        private readonly IMapper _mapper;
        private readonly IProductReader _productReader;

        public GetProductDetailQueryHandler(IMapper mapper, IProductReader productReader)
        {
            _mapper = mapper;
            _productReader = productReader;
        }

        public async Task<ResultDTO<ProductDetailSiteDTO>> Handle(GetProductDetailQuery request, CancellationToken cancellationToken)
        {
            var product = await _productReader.GetProductDetail(request.Id);

            return new ResultDTO<ProductDetailSiteDTO>()
            {
                Data = new ProductDetailSiteDTO
                {
                    Category = $"{product.Category.ParentCategory.Name}  - {product.Category.Name}",
                    Description = product.Description,
                    Id = product.Id,
                    Price = product.Price,
                    Title = product.Title,
                    Images = product.ProductImages.Select(p => p.Src).ToList(),
                    Features = product.ProductFeatures.Select(p => new ProductFeatureDTO
                    {
                        DisplayName = p.DisplayName,
                        Value = p.Value,
                    }).ToList(),

                },
                IsSuccess = true,
            };
        }
    }
}
