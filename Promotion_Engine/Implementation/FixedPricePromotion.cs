using System.Collections.Generic;
using System.Linq;
using Promotion_Engine.Constants;
using Promotion_Engine.Contracts;
using Promotion_Engine.Interface;

namespace Promotion_Engine.Implementation
{
    public class FixedPricePromotion : IPromotion
    {
        public (decimal finalPrice, List<ProductToBuy> productsToBuy) ApplyPromotion(List<ProductToBuy> productsToBuy, decimal finalPrice)
        {
            foreach (var fixedPromotion in Promotions.FixedPricePromotions)
            {
                var fixedPriceApplicableProducts = productsToBuy.Where(obj => obj.Product.Name == fixedPromotion.Product.Name);
                var priceApplicableProducts = fixedPriceApplicableProducts as ProductToBuy[] ?? fixedPriceApplicableProducts.ToArray();
                if (priceApplicableProducts.Any())
                {
                    // Calulate no of items in batch for discount
                    var batchesOnDiscount = priceApplicableProducts.FirstOrDefault()?.Count / fixedPromotion.PromoItemCount;
                    if (batchesOnDiscount > 0)
                    {
                        finalPrice += batchesOnDiscount.Value * fixedPromotion.PromoPrice;
                    }
                    // Calulate no of items Not in batch for discount
                    var itemsNotInDiscount = priceApplicableProducts.FirstOrDefault()?.Count % fixedPromotion.PromoItemCount;
                    if (itemsNotInDiscount > 0)
                    {
                        finalPrice += itemsNotInDiscount.Value * fixedPromotion.Product.Price;
                    }
                    productsToBuy.RemoveAll(obj => priceApplicableProducts.Select(productToBuy => productToBuy.Product.Name).Contains(obj.Product.Name));
                }
            }
            return (finalPrice, productsToBuy);

        }
    }
}
