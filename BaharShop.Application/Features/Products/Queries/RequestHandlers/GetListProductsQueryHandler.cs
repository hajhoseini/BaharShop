using MediatR;
using AutoMapper;
using BaharShop.Domain.IReaders.Products;
using BaharShop.Application.DTOs.Products;
using BaharShop.Application.Features.Products.Queries.Requests;

namespace BaharShop.Application.Features.Products.Queries.RequestHandlers
{
    public class GetListProductsQueryHandler : IRequestHandler<GetListProductsQuery, List<ProductDTO>>
	{
		private readonly IMapper _mapper;
		private readonly IProductReader _productReader;

		public GetListProductsQueryHandler(IMapper mapper, IProductReader productReader)
		{
			_mapper = mapper;
			_productReader = productReader;
		}

		public async Task<List<ProductDTO>> Handle(GetListProductsQuery request, CancellationToken cancellationToken)
		{
			var all = await _productReader.GetList(null, null);
			return _mapper.Map<List<ProductDTO>>(all.ToList());
		}
	}
}