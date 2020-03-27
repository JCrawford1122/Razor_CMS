using CMS.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CMS.Data
{
    public interface ICmsData
    {
        IEnumerable<Customer> GetCustomersByName(string customerName);
    }

    // Used for in development data
    public class InMemoryCustomers : ICmsData
    {
        List<Customer> customers;
        public InMemoryCustomers()
        {
            customers = new List<Customer>()
            { 
                new Customer{Id = 1, LastName = "Crawford", FirstName = "Justin", PhoneNumber = "3605516855", 
                    Address = "3321 Perry Ave", City = Customer.Cities.Phoenix, Country = Customer.Countries.United_States},
                new Customer{Id = 2, LastName ="Brilinski", FirstName="Tyler", PhoneNumber="360-710-1111",
                    Address = "123 Fir St", City = Customer.Cities.New_York, Country = Customer.Countries.United_States},
                new Customer{Id = 2, LastName = "Crawford", FirstName="Max", PhoneNumber = "360-123-4567",
                    Address = "987 Pine St", City = Customer.Cities.London, Country = Customer.Countries.England}

            };
        }
        public IEnumerable<Customer> GetCustomersByName(string customerName = null)
        {
            return from c in customers
                   where string.IsNullOrEmpty(customerName) || c.LastName.StartsWith(customerName)
                   orderby c.LastName
                   select c;
        }
    }
}
