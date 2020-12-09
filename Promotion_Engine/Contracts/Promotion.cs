using System.Collections.Generic;

namespace Promotion_Engine.Contracts
{
    public  class Promotion
    {
        public Product Product { get; set; }
        public List<Product> Products { get; set; }
        public int PromoItemCount { get; set; }
        public int PromoPrice { get; set; }
    }
}
