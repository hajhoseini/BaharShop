using MediatR;
using AutoMapper;
using BaharShop.Domain.IReaders.Products;
using BaharShop.Application.DTOs.Products;
using BaharShop.Application.Features.Products.Queries.Requests;

namespace BaharShop.Application.Features.Products.Queries.RequestHandlers
{
    public class GetProductQueryHandler : IRequestHandler<GetProductQuery, ProductDTO>
    {
        private readonly IMapper _mapper;
        private readonly IProductReader _productReader;

        public GetProductQueryHandler(IMapper mapper, IProductReader productReader)
        {
            _mapper = mapper;
            _productReader = productReader;
        }

        public async Task<ProductDTO> Handle(GetProductQuery request, CancellationToken cancellationToken)
        {
            var productEntity = await _productReader.GetById(request.Id, "Category");
            return _mapper.Map<ProductDTO>(productEntity);
        }
    }
}
