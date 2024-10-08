﻿using MediatR;
using BaharShop.Application.DTOs.Products;
using BaharShop.Common;
using BaharShop.Common.Enums;

namespace BaharShop.Application.Features.Products.Queries.Requests
{
    public class GetListProductsSiteQuery : IRequest<ResultDTO<ResultProductsListSiteDTO>>
    {
        public int CurrentPage { get; set; }

        public int PageSize { get; set; }

        public int? CategoryId { get; set; }

        public string SearchKey { get; set; }

        public ProductOrderingEnum Ordering { get; set; }
    }
}