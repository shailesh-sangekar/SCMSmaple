using System;

namespace CORE_TEST_GIT
{
    class Program
    {
        static void Main(string[] args)
        {
            Guid _id = Guid.NewGuid();
            Console.WriteLine("Test Data - " + _id);
            getProducts();
        }

        static void getProducts()
        {
            //BLProducts products = new BLProducts();
        }

    }
}
