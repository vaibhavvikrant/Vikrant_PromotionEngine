﻿using System.Collections.Generic;
using Promotion_Engine.Interface;

namespace Promotion_Engine.Contracts
{
    public class Sku
    {
        public decimal FinalPrice { get; set; }
        List<ProductToBuy> ProductsToBuy { get; set; }
        public decimal PromotionalPrice
        {
            get
            {
                // All the classes implementing IPromotion, their Applypromotion method will be called from here.
                foreach (var promotion in ApplyPromotion)
                {
                    promotion.ApplyPromotion(ProductsToBuy);
                }

                return FinalPrice;
            }
        }
        public Sku(List<ProductToBuy> productsToBuy)
        {
            ProductsToBuy = productsToBuy;
        }

        //Add all the new implementation of IPromotion
        public List<IPromotion> ApplyPromotion => new List<IPromotion>();
    }
}
