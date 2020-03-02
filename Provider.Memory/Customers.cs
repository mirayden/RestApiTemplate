using System;
using System.Collections.Generic;
using Domain;

namespace Provider.Memory
{
    public class Customers : ICustomers
    {
        private readonly IList<ICustomer> _customers = new List<ICustomer>();        
        
        public void AddCustomer(string firstName, string lastName)
        {
            _customers.Add(new Customer(firstName, lastName));
        }

        public IEnumerable<ICustomer> All()
        {
            return _customers;
        }
    }
}