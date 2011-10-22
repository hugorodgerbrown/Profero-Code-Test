using Profero.Interview.Business.Basket;
using Profero.Interview.Business.Core;

namespace Profero.Interview.Business
{
    public interface IRemoveFromBasketCommand : ICommand<int, bool>{}
    public interface IAddToBasketCommand : ICommand<AddToBasketRequest, AddToBasketResponse>{}
}