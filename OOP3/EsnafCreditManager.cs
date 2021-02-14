using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class EsnafCreditManager : ICreditService
    {
        public void Calculate()
        {
            Console.WriteLine("Esnaf kredisi hesaplandı.");
        }
    }
}
