using Profero.Interview.Business.Basket;
using Profero.Interview.Business.Core;
using Profero.Interview.Business.Shipping;

namespace Profero.Interview.Business
{
    public interface IGetBasketQuery : IQuery<BasketRequest, Basket.Basket>{}
    public interface IGetShippingOptionsQuery: IQuery<GetShippingOptionsRequest, GetShippingOptionsResponse>{}
}