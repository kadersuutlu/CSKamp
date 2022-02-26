using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //InterfacesIntro();

            //Interface kendi başına new'lenemez.
            //IPerson person=new Customer();

            //Demo();

            ICustomerDal[] customerDals = new ICustomerDal[3] 
            { 
                new SqlServerCustomerDal(),
                new OracleCustomerDal(),
                new MySqlCustomerDal()
            };

            foreach (var customer in customerDals)
            {
                customer.Add();
            }

            

            Console.ReadLine();
            
        }

        private static void Demo()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new SqlServerCustomerDal());
            customerManager.Add(new OracleCustomerDal());
        }

        private static void InterfacesIntro()
        {
            PersonManager personManager = new PersonManager();
            personManager.Add(new Customer { Id = 1, FirstName = "Kader", LastName = "Sutlu", Address = "İstanbul" });
            Customer customer = new Customer
            {
                Id = 2,
                FirstName = "Engin",
                LastName = "Demiroğ",
                Address = "Ankara"
            };
            personManager.Add(customer);

            Student student = new Student
            {
                Id = 3,
                FirstName = "Derin",
                LastName = "Demiroğ",
            };
            personManager.Add(student);


            Console.ReadLine();
        }
    }

    //soyut nesne
    interface IPerson //Temel nesne oluşturup diğer nesneleri ordan implemente etmek
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }

    //somut nesne
    class Customer:IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Address { get; set; }
    }

    class Student:IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Departmant { get; set; }
    }

    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
