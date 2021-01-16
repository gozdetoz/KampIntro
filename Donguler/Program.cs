using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //array - dizi 
            string[] kurslar = new string[] {"Yazılım Geliştirici Yetiştirme Kampı","Programlamaya başlangıç için temel kurs","Java","C#" ,"Python"};
            Console.WriteLine("-------------Foreach ile Yapılan----------------");
            foreach (var item in kurslar)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-------------For ile Yapılan----------------");
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("Sayfa Sonu -footer");
        }
    }
}
