﻿using Profero.Interview.Business.Basket;

namespace Profero.Interview.Business.Shipping
{
    public class FlatRateShipping : ShippingBase
    {
        public override string GetDescription(LineItem lineItem, Basket.Basket basket)
        {
            return "Flat rate shipping";
        }

        public override decimal GetAmount(LineItem lineItem, Basket.Basket basket)
        {
            return FlatRate;
        }

        public decimal FlatRate { get; set; }
    }
}