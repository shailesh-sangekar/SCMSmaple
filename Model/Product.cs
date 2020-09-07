using System;

namespace CORE_TestAPP
{
    public class Product
    {
        public Guid ID { get; set; }
        public ProductType Type { get; set; }
        public ProductCategory Category { get; set; }
        
    }
}