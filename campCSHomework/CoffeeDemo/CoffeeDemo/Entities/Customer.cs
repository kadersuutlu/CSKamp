using System;

namespace CoffeeDemo
{
    public class Customer:IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateofBirthday { get; set; }
        public string NationalityId { get; set; }
    }
}
