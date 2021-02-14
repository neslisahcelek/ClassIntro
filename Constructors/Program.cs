using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer { Id = 1, FirstName = "Neslişah", LastName = "Çelek", City = "Antalya" };
            Customer customer2 = new Customer (2, "Sinan", "Çelek", "Kocaeli");

        }
    }

    class Customer
    {
        //default constructor
        public Customer()
        {

        }

        public Customer(int id, string firstName, string lastName, string city )
        {
            id = Id;
            firstName = FirstName;
            lastName = LastName;
            city = City;
      
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
