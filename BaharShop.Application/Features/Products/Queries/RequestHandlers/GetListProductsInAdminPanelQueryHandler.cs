﻿using MediatR;
using AutoMapper;
using BaharShop.Domain.IReaders.Products;
using BaharShop.Application.DTOs.Products;
using BaharShop.Application.Features.Products.Queries.Requests;
using BaharShop.Common;

namespace BaharShop.Application.Features.Products.Queries.RequestHandlers
{
    public class GetListProductsInAdminPanelQueryHandler : IRequestHandler<GetListProductsInAdminPanelQuery, ResultDTO<ProductsListAdminPanelDTO>>
	{
		private readonly IMapper _mapper;
		private readonly IProductReader _productReader;

		public GetListProductsInAdminPanelQueryHandler(IMapper mapper, IProductReader productReader)
		{
			_mapper = mapper;
			_productReader = productReader;
		}

		public async Task<ResultDTO<ProductsListAdminPanelDTO>> Handle(GetListProductsInAdminPanelQuery request, CancellationToken cancellationToken)
		{
            int rowCount = 0;

            var products = _productReader.GetListProductsInAdminPanel(request.CurrentPage, request.PageSize, out rowCount);

            return new ResultDTO<ProductsListAdminPanelDTO>()
            {
                Data = new ProductsListAdminPanelDTO()
                {
                    Products = _mapper.Map<List<ProductDTO>>(products),
                    CurrentPage = request.CurrentPage,
                    PageSize = request.PageSize,
                    RowCount = rowCount
                },
                IsSuccess = true,
                Message = "",
            };
        }
    }
}