using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    interface ICreditManager
    {
        //İmzanın aynı oldugu fakat içerisinin farklı oldugu durumlarda interface kullanırız
        //Bir interface sunu anlatır .Eger kı bırı bu ınterface kullanırsa o bu metotları içermek zorundadır .
        //
        void Calculate();
        void Write();

    }
}
