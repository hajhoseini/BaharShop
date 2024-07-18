﻿using BaharShop.Domain.Entities.Base;

namespace BaharShop.Domain.Entities.Products
{
    public class ProductFeature : BaseEntity
    {
        public string DisplayName { get; set; }

        public string Value { get; set; }

        public virtual Product Product { get; set; }

        public int ProductId { get; set; }
    }
}
