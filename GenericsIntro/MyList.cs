using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;
using System.IO;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;
        //constructor   --bu class her newlendıgınde burası otomatık calısacaktır
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items;//gecici dizinin referansını items ın referansı yap .Boylelıkle elımızdekı elemenalrımız kaybolmuyor
            items = new T[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            items[items.Length - 1] = item;

        }
     
    }
}
