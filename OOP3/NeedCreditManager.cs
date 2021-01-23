using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{

    //ihtiyac kredisi
    class NeedCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("İhtiyaç kredisi ödeme planı hesaplandı");
        }

        public void Write()
        {
            throw new NotImplementedException();
        }
    }
}
