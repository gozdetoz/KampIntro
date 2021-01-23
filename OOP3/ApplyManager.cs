using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ApplyManager
    {
       
        //Başvuru yap
        //Method injection yapıyoruz.Asla hangi kredi hangı loglayıcı olduguna daır bılgı yok .Sadece soyut halleri var biz somut hallerını enjecte ederız.Yanı kredı interfacemız ona baglı tum kredılerın
        public void ToApply(ICreditManager creditManager,ILoggerService loggerService)
        {
            // Başvuran bilgilerini değerlendirme

            // Bu yapılırsa tüm başvurular konut kredisine bağımlı haline getirir!
            //KonutKrediManager konutKrediManager = new KonutKrediManager(); 
            //konutKrediManager.Hesapla();

            creditManager.Calculate(); // Bu formatta hangi kredi gönderilirse o çalışır.
            loggerService.Log();//Hangi loglayıcıc secılmısse ona göre logla
        }
        //kredi on bilgilendirmesiYap
        public void CreditPreliminaryInformation(List<ICreditManager> credits)
        {
            //kaç tane kredi sececegi belli degil .Aynı veri türünde belli sayıda o sayıda belirsizce bir veri tutuyorsak bir liste oluştururuz
            //ICreditManager türünde bir liste olusturduk 
            foreach (var credi in credits)
            {
                credi.Calculate();

            }

        }
    }
}
