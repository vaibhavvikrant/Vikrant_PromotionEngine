﻿using System.Collections.Generic;
using Promotion_Engine.Contracts;

namespace Promotion_Engine.Constants
{
    public class Promotions
    {
        public static List<Promotion> FixedPricePromotions { get; } = new List<Promotion>
        {
            new Promotion{ Product= Products.ProductA, PromoItemCount = 3, PromoPrice= 130},
            new Promotion{ Product= Products.ProductB, PromoItemCount = 2, PromoPrice= 45}
        };
        public static List<Promotion> FixedPricePromotionsType2 { get; } = new List<Promotion>
        {
            {new Promotion{ Products= new List<Product>{Products.ProductC, Products.ProductD }, PromoPrice= 30} }
        };

    }
}
