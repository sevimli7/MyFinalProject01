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
            // Product product1 = new Product() { CategoryId = 2, ProductName = "tablo" };
            //productManager.Add(product1);
            //productManager.Delete(product1);
            //Test01();
            //Test02();
            //AddProduct(product1);
            //GetAllTest();
            AllCategoryTest();
            //ProductDetailsDto();


            //ProductManager productManager = new ProductManager(new EfProductDal());
            //productManager.Add(new Product {  CategoryId = 2, ProductName = "patates", UnitsInStock = 2, UnitPrice = 5 });
            //foreach (var p in productManager.GetAll().Data)
            //{
            //    Console.WriteLine(p.ProductName);
            //}

        }

        private static void ProductDetailsDto()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            var result = productManager.GetProductDetails();
            if (result.Success==true)
            {
                foreach (var p in result.Data)
                {
                    Console.WriteLine(p.ProductId + " *** " + p.ProductName + " *** " + p.CategoryName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
            
        }

        private static void AllCategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            var result1 = categoryManager.GetAll();
            foreach (var category in result1.Data)
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void GetAllTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var p in productManager.GetAll().Data)
            {
                Console.WriteLine(p.ProductId + " " + p.ProductName);
            }
        }

        private static void AddProduct(Product product1)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            productManager.Add(product1);

            foreach (var product in productManager.GetAll().Data)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        //private static void Test02()
        //{
        //    ProductManager productManager = new ProductManager(new EfProductDal());

        //    foreach (var product in productManager.GetById(2))
        //    {
        //        Console.WriteLine(product.ProductName);
        //    }
        //}

        private static void Test01()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            foreach (var product in productManager.GetByUnitPrice(40, 50).Data)
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}
