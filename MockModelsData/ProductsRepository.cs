using System;
using System.Collections.Generic;


namespace CORE_TestAPP
{
    public class ProductRepository
    {
        private List<Product> _data;
        public List<Product> Data
        {
            get { return _data; }
            set { _data = value; }
        }

        ProductRepository()
        {
            _data = new List<Product>() {
                new Product() { ID= Guid.NewGuid(), Type = new ProductType(){ ID=1, Name = "Book"}, Category = new ProductCategory(){ ID= 1, Name= "Study"} },
                new Product() { ID= Guid.NewGuid(), Type = new ProductType(){ ID=1, Name = "Book"}, Category = new ProductCategory(){ ID= 1, Name= "Study"} },
                new Product() { ID= Guid.NewGuid(), Type = new ProductType(){ ID=1, Name = "Book"}, Category = new ProductCategory(){ ID= 1, Name= "Study"} },
                new Product() { ID= Guid.NewGuid(), Type = new ProductType(){ ID=1, Name = "Book"}, Category = new ProductCategory(){ ID= 1, Name= "Study"} },
                new Product() { ID= Guid.NewGuid(), Type = new ProductType(){ ID=1, Name = "Book"}, Category = new ProductCategory(){ ID= 1, Name= "Study"} },
                new Product() { ID= Guid.NewGuid(), Type = new ProductType(){ ID=1, Name = "Book"}, Category = new ProductCategory(){ ID= 1, Name= "Study"} },
                new Product() { ID= Guid.NewGuid(), Type = new ProductType(){ ID=1, Name = "Book"}, Category = new ProductCategory(){ ID= 1, Name= "Study"} },
            };
        }


    }
}