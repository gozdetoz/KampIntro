using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    //snippet --hazır kodlar demek kısaltmalarını yazıp tab tab yapınca tanımlanana kodlar
    // Class isimleri Pascal case yazılır ve çogul isimlendırme yapılmaz.Bu tip classlarda sadece urun ozellıklerı olur .CRUD operasyonlarının oldugu classlarda sadece bu işlemleri tanımlamalı.Bunlarıda Manager yada Service isimlendirmeleri alr .ProductManager gibi bu ürünle ilgili operasyonları içerir.
    class Product
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitsInStock { get; set; }



    }
}
