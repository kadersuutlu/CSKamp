using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer { Id = 1,FirstName="Engin",LastName="Demiroğ",City="Ankara" };
            Customer customer2 = new Customer ( 2, "Derin", "Demiroğ", "Ankara" );
            Customer customer3 = new Customer ( );
            customer3.Id = 1;
            customer3.FirstName = "Engin";
            customer3.LastName = "Demiroğ";
            customer3.City = "Ankara";
        }
        
    }

    class Customer
    {
        //default constructor
        public Customer()
        {

        }
        // Aşağıdaki giibi constructor tanımlandığında default olan eziir.
        public Customer(int id, string firstName, string lastName, string city)//class'ın ismiyle aynı, fakat sonunda parantez var bir metot gibi
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
