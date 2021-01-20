using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product { Id = 2, CategoryId = 5, ProductName = "Kalem", UnitsInStock = 5, UnitPrice = 35 };

            //Pascal Case  //camelCase
            //case sensitive -- Kucuk Buyuk harf duyarlılık
            //sol taraf stack               //sağ taraf heap //asagıdakı satıra gore new yapılan yer
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);

            
            //int,double,bool ... deger tiptir
            //diziler,class,abstract class,interface ...referans tiptir
            //ref out
        }
    }
}
