using System;

namespace CORE_TestAPP
{
    public class BLProducts : IBLProducts
    {
        public Product AddProduct(Product product)
        {
            try
            {
                product.ID = Guid.NewGuid();
                // TODO :: Update new data to DB and return that public data to developer to show success mesage.
                return new Product();

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
        public string DeleteProudct(Product product, Guid id)
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