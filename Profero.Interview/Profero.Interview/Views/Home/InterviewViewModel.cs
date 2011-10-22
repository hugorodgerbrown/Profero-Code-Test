using System.Collections.Generic;
using Profero.Interview.Business.Basket;
using Profero.Interview.Business.Shipping;

namespace Profero.Interview.Views.Home
{
    public class InterviewViewModel
    {
        public Dictionary<string, ShippingBase> ShippingOptions { get; set; }
        public Basket Basket { get; set; }
    }
}