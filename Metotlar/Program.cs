using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] {urun1,urun2 };
            //type-safe  -- tip güvenli
            foreach (Urun urun in urunler)
            {
                Console.WriteLine("Urun Adı : " +urun.Adi +"  Fiyatı : " +urun.Fiyati +"  Açıklaması : " +urun.Aciklama);
            }
            
            Console.WriteLine("------------Metotlar--------------");
            //instance  --örnek  :New ile o classın Örnegini olustururuz
            //metotalarla tekrar tekrar aynı seyi kullanabilme imkanı sagladık 
            //encapsulation  :urun ozellıgı bir ozellık daha eklendıgınde sace urun clasına eklememız yeterlı dıger metorlarda bunu kullanmıs olacak .Kapsulleme ayrı ayrı yazacagın bırseyı tek bir yerde toplamak kapsullemmek ve onu kullanmaktır.



            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut","Yeşil Armut" ,12,10);
            sepetManager.Ekle2("Elma","Yeşil Elma" ,12,9);
            sepetManager.Ekle2("Karpuz","Diyarbakır Karpuzu" ,12,8);


        }
    }
}
// Metotlar tekrar tekrar kullanmayı saglar
// Dont repeat yourself  -DRY  --Clean Code -Best Practice
//Class adları pascal Case ile yazılır .Ilk Harf Buyuk diğerleri Kucuk