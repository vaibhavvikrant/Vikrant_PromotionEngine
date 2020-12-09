using System.Collections.Generic;
using NUnit.Framework;
using Promotion_Engine.Contracts;

namespace PromotionEngineTest
{
    [TestFixture]
    public class PromotionEngineTest
    {
        [Test]
        public void FixedPriceTest()
        {
            var product = new ProductToBuy { Product = Products.ProductA, Count = 1 };
            var obj = new Sku(new List<ProductToBuy> { product });
            var finalPrice = obj.PromotionalPrice;
            Assert.AreEqual(50, finalPrice);
        }
    }
}
