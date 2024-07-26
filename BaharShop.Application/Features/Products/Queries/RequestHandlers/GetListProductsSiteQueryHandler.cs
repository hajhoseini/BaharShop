using MediatR;
using BaharShop.Domain.IReaders.Products;
using BaharShop.Application.DTOs.Products;
using BaharShop.Application.Features.Products.Queries.Requests;
using BaharShop.Common;

namespace BaharShop.Application.Features.Products.Queries.RequestHandlers
{
    public class GetListProductsSiteQueryHandler : IRequestHandler<GetListProductsSiteQuery, ResultDTO<ResultProductsListSiteDTO>>
	{
		private readonly IProductReader _productReader;

		public GetListProductsSiteQueryHandler(IProductReader productReader)
		{
			_productReader = productReader;
		}

		public async Task<ResultDTO<ResultProductsListSiteDTO>> Handle(GetListProductsSiteQuery request, CancellationToken cancellationToken)
		{
            int totalRow = 0;

            var products = _productReader.GetListProductsSite(request.CurrentPage, out totalRow);

            Random rd = new Random();
            return new ResultDTO<ResultProductsListSiteDTO>
            {
                Data = new ResultProductsListSiteDTO
                {
                    TotalRow = totalRow,
                    Products = products.Select(p => new ProductsListSiteDTO
                    {
                        Id = p.Id,
                        Star = rd.Next(1, 5),
                        Title = p.Title,
                        ImageSrc = (p.ProductImages.FirstOrDefault() == null ? "" : p.ProductImages.FirstOrDefault().Src),
                        Price = p.Price
                    }).ToList(),
                },
                IsSuccess = true,
            };
        }
    }
}