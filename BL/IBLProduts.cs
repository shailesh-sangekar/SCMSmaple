using System;

namespace CORE_TestAPP
{
    public interface IBLProducts
    {
        Product AddProduct(Product product);
        string UpdateProduct(Product product, Guid id);
        string DeleteProduct(Product product, Guid id);
    }
}