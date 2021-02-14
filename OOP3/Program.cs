using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {   //***********//
            ICreditService ihtiyacCreditManager = new IhtiyacCreditManager();
            ICreditService tasitCreditManager = new TasitCreditManager();
            ICreditService konutCreditManager = new KonutCreditManager();
          
            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.GetApplication(new EsnafCreditManager(), new List<ILoggerService> { new DatabaseLoggerService(), new SmsLogger() });//*****new

            List<ICreditService> credits = new List<ICreditService>() { konutCreditManager, tasitCreditManager, ihtiyacCreditManager };
            applicationManager.GetCreditInformation(credits);

        }
    }
}
