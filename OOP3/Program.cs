using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        //İnterface onu ımplemente eden clasların referanslarını tutabılır
        //interface   birbirlerinin alternatifi olan fakat kod içeriklerinin farklı oldugu orneklerde kullanırız
        //
        static void Main(string[] args)
        {
            ICreditManager needCreditManager = new  NeedCreditManager();
            //needCreditManager.Calculate();

            ICreditManager transportCreditManager =new  TransportCreditManager();
            //transportCreditManager.Calculate();

            ICreditManager mortgageCreditManager = new MortgageCreditManager();
            //mortgageCreditManager.Calculate();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            
            ApplyManager applyManager = new ApplyManager();
            applyManager.ToApply(transportCreditManager,databaseLoggerService);
            applyManager.ToApply(transportCreditManager,fileLoggerService);
            //applyManager.ToApply(transportCreditManager, new DatabaseLoggerService());//bu sekıldede tanımlayabılırız


            List<ICreditManager> credits = new List<ICreditManager>() { needCreditManager , transportCreditManager , mortgageCreditManager };
            //applyManager.CreditPreliminaryInformation(credits);



        }
    }
}
