using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.CustomerNumber = "12345";
            customer1.Name = "Engin";
            customer1.LastName = "Demiroğ";
            customer1.PersonalId = "12345678910";

            CoorporateCustomer customer2 = new CoorporateCustomer();
            customer2.Id = 2;
            customer2.CustomerNumber = "54321";
            customer2.CompanyName = "Kodlama.io";
            customer2.TaxNumber = "1234567890";

            //******************//
            Costumer costumer3 = new IndividualCustomer(); 
            Costumer costumer4 = new CoorporateCustomer();

            CostumerManager costumerManager = new CostumerManager();
            costumerManager.Add(costumer1);
            costumerManager.Add(costumer3);

        }
    }
}
