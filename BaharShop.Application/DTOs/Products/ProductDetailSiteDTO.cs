﻿namespace BaharShop.Application.DTOs.Products
{
    public class ProductDetailSiteDTO
    {
        public long Id { get; set; }

        public string Title { get; set; }

        public string Category { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public List<string> Images { get; set; }

        public List<ProductFeatureDTO> Features { get; set; }
    }
}
