using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //int decimal, float,double ,bool değer tiptir .Değer tip olanlar stack de gerceklesir

            //array,interface vb. referans tiptir  //referans tipler heap de tutulur 
            //
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1 ?? 30 

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            Console.WriteLine(sayi1);
            Console.WriteLine(sayilar1[0]);
            //sayilar1[0] ?? 999
        }
    }
}
