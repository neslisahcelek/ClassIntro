using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ApplicationManager
    {
        public void GetApplication(ICreditService creditManager, List<ILoggerService> loggerServices)
        {
            creditManager.Calculate();
            foreach (ILoggerService loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }

        //birkaç tane krediyi aynı anda hesaplar
        public void GetCreditInformation(List<ICreditService> credits)
        {
            foreach (var credit in credits)
            {
                credit.Calculate();
            }
        }
    }
}
