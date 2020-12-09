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
            var product1 = new ProductToBuy { Product = Products.ProductB, Count = 1 };
            var product2 = new ProductToBuy { Product = Products.ProductC, Count = 1 };
            var obj = new Sku(new List<ProductToBuy> { product, product1, product2 });
            var finalPrice = obj.PromotionalPrice;
            Assert.AreEqual(100, finalPrice);

            product = new ProductToBuy { Product = Products.ProductA, Count = 5 };
            product1 = new ProductToBuy { Product = Products.ProductB, Count = 5 };
            product2 = new ProductToBuy { Product = Products.ProductC, Count = 1 };
            obj = new Sku(new List<ProductToBuy> { product, product1, product2 });
            finalPrice = obj.PromotionalPrice;
            Assert.AreEqual(370, finalPrice);
        }
    }
}
