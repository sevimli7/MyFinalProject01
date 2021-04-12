using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product() { CategoryId = 2, ProductName = "tablo" };
            //productManager.Add(product1);
            //productManager.Delete(product1);

            //Test01();
            //Test02();

            //AddProduct(product1);
            //GetAllTest();

        }

        private static void GetAllTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var p in productManager.GetAll())
            {
                Console.WriteLine(p.ProductId + " " + p.ProductName);
            }
        }

        private static void AddProduct(Product product1)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            productManager.Add(product1);

            foreach (var product in productManager.GetAll())
            {
                Console.WriteLine(product.ProductName);
            }
        }

        private static void Test02()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            foreach (var product in productManager.GetAllByCategoryId(2))
            {
                Console.WriteLine(product.ProductName);
            }
        }

        private static void Test01()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            foreach (var product in productManager.GetByUnitPrice(40, 50))
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}
