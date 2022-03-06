using CoffeeDemo.Abstract;
using ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeDemo.Adapters
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient kPSPublicSoapClient = new();
            using var client = kPSPublicSoapClient;
            return client.TCKimlikNoDogrula(Convert.ToInt64(customer.NationalityId), customer.FirstName.ToUpper,
                customer.LastName.ToUpper, customer.DateofBirthday.Year);
        }
    }
}   
