using System;
using System.Collections.Generic;

namespace CORE_TestAPP
{
    public class BLProducts : IBLProducts
    {
        private List<Product> _productsData { get; set; }

        BLProducts(ProductRepository productRep)
        {
            _productsData = productRep.Data;

        }
        public Product AddProduct(Product product)
        {
            try
            {
                // TODO :: Update new data to DB and return that public data to developer to show success mesage.
                product.ID = Guid.NewGuid();
                _productsData.Add(product);
                return product;

            }
            catch (System.Exception)
            {

                // TODO :: add exception to log
                throw new Exception("Somthing Went Wrong !");
            }

        }

        public string UpdateProduct(Product product, Guid id)
        {
            try
            {
                // TODO :: Get Product By id and update latest data

                return "Prouct " + id + " is updated Sucessfully !";
            }
            catch (System.Exception)
            {

                // TODO :: add exception to log

                return "Somthing Went Wrong !";

            }




        }
        public string DeleteProduct(Product product, Guid id)
        {
            try
            {
                // TODO :: Get Product By id and perform Delete Operation

                return "Prouct " + id + " is Deleted Sucessfully !";
            }
            catch (System.Exception)
            {

                // TODO :: add exception to log

                return "Somthing Went Wrong !";

            }

        }
    }

}