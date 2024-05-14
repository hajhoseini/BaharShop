﻿using BaharShop.Common.Enums;
using BaharShop.Domain.Entities.Base;

namespace BaharShop.Domain.Entities.Orders
{
    public class Order : BaseEntity
    {
        public int Code { get; set; }
        public int CustomerId { get; set; }
        public int AddressId { get; set; }        
        public DateTime OrderDate { get; set; }
        public DateTime DeliveryDate { get; set; }
        public decimal OrderPrice { get; set; }
        public decimal SendPrice { get; set; }
        public decimal TotalPrice { get; set; }
        public PaymentTypeEnum PaymentType { get; set; }
    }
}
