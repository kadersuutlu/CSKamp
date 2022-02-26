using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Inheritance genelde abstruct sınıflarda kullanılır.
namespace Inheritance //Inheritance da bir nesne sadece 1 kez inheritance alınabilir, birden fazla kez implemente edilebilir.
{ //Önce inheritance sonra inteface ler kaç tane varsa yazılır. class ların tek başına anlamı varken,,interface lerin tek başına anlamı yoktur. İkisi de inheritance gibi kullanılabilir.
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[3]
            {
                new Customer{FirstName="Engin"},
                new Student{FirstName="Engin"},
                new Person{FirstName="Engin"},
            };

            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);
            }

            Console.ReadLine();
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public int LastName { get; set; }
    }

    class Person2
    {

    }

    class Customer : Person //,Person2
    {
        public string City { get; set; }
    }

    class Student : Person
    {
        public string Department { get; set; }
    }
}
