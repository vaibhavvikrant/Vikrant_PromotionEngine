using System.Collections.Generic;
using Promotion_Engine.Contracts;

namespace Promotion_Engine.Interface
{
    public interface IPromotion
    {
        (decimal finalPrice, List<ProductToBuy> productsToBuy) ApplyPromotion(List<ProductToBuy> productsToBuy, decimal finalPrice);
    }
}
