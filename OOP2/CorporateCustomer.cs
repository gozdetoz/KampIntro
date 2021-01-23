using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //Tüzel Müşteri
    //miras-inheritance denir (CorporateCustomer:Customer) tüzel müşteri bir müşteridir.Asıl olayı  müsteride olan ozellıkler artık gercekte de tuzel musterıde vardır .Ortak olanlar her ıkısınde de vardır .

    class CorporateCustomer :Customer
    {
     
        public string CompanyName { get; set; }
        public string TaxNumber { get; set; }
    }
}
