﻿using BaharShop.Common.Enums;
using BaharShop.Domain.Entities.Products;

namespace BaharShop.Domain.IReaders.Products
{
    public interface IProductReader : IGenericReader<Product>
    {
        List<Product> GetListProductsInAdminPanel(int currentPage, int pageSize, out int rowCount);

        List<Product> GetListProductsSite(int page, int pageSize, out int totalRow, int? categoryId, string searchKey, ProductOrderingEnum ordering);

        Task<Product> GetProductDetail(int id); 
    }
}