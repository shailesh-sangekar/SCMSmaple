using System;
using System.Collections.Generic;


namespace CORE_TestAPP
{
    public class ProductTypeRepository
    {
        private List<ProductType> _data;
        public List<ProductType> Data
        {
            get { return _data; }
            set { _data = value; }
        }

        ProductTypeRepository()
        {
            _data = new List<ProductType>() {
                new ProductType() { ID=1, Name = "ABC1" },
                new ProductType() { ID=2, Name = "ABC2" },
                new ProductType() { ID=3, Name = "ABC3" },
                new ProductType() { ID=4, Name = "ABC4" },
                new ProductType() { ID=5, Name = "ABC5" },
                new ProductType() { ID=6, Name = "ABC6" },
            };
        }


    }
}