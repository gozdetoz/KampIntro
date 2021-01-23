using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //GercekMusteri
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.CustomerId = 1;
            customer1.CustomerNumber = "12345";
            customer1.Name = "Gözde";
            customer1.Surname = "Toz";
            customer1.IdentityNumber = "11111111111";

            //TuzelMusteri
            CorporateCustomer customer2 = new CorporateCustomer();
            customer2.CustomerId = 2;
            customer2.CustomerNumber = "123456";
            customer2.CompanyName = "Kodlama.Io";
            customer2.TaxNumber = "1234567890";

            //Gercek -Tüzel
            //SOLID
            //L-Birbirine Benziyor diye aynı yapma

            Customer customer3 = new IndividualCustomer();
            Customer customer4 = new CorporateCustomer();
            // müşteri - gercek müşteri ve tüzel müşteri referanslarını da tutabılır .Mıras ın en onemlı noktasıdır 
            //CustomerMAneger da customer customer diye ımza attık artık her ıkı mustarı referansınıda gonderebiliriz.
            //poliformizim
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);



        }
    }
}
