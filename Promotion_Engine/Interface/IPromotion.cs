using System.Collections.Generic;
using Promotion_Engine.Contracts;

namespace Promotion_Engine.Interface
{
    public interface IPromotion
    {
        decimal ApplyPromotion(List<ProductToBuy> productsToBuy);
    }
}
