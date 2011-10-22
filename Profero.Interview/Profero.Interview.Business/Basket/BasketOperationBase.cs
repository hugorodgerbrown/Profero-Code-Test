using System.Collections.Generic;
using System.IO;
using Profero.Interview.Business.Core;

namespace Profero.Interview.Business.Basket
{
    public abstract class BasketOperationBase
    {
        const string file = @"c:\temp\basket.xml";

        protected Basket GetBasket()
        {
            if (!File.Exists(file))
                return new Basket {LineItems = new List<LineItem>(),};

            using (var sr = new StreamReader(file))
            {
                return SerializationHelper.DataContractDeserialize<Basket>(sr.ReadToEnd());
            }
        }

        protected void SaveBasket(Basket basket)
        {
            using (var sw = new StreamWriter(file, false))
            {
                sw.Write(SerializationHelper.DataContractSerialize(basket));
            }
        }
    }
}