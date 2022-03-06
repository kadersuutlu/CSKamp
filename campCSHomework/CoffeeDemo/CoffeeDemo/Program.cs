using CoffeeDemo.Abstract;
using CoffeeDemo.Concrete;
using System;

namespace CoffeeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new NeroCustomerManager();
            customerManager.Save(new Customer { 
                DateofBirthday = new DateTime(2000, 9, 9), 
                FirstName = "Kader", 
                LastName = "Sutlu", 
                NationalityId = "10021890900" 
            });
        }


    }
}
