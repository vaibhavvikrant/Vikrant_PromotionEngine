using System.Collections.Generic;
using Promotion_Engine.Contracts;

namespace Promotion_Engine.Implementation
{
    public static class ItemsWithoutDiscount 
    {
        public static decimal ApplyPromotion(List<ProductToBuy> productsToBuy, decimal finalPrice)
        {
            productsToBuy.ForEach(obj =>
                finalPrice += obj.Product.Price * obj.Count
            );
            return finalPrice;
        }
    }
}
