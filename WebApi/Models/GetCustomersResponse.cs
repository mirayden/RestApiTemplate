using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Domain;

namespace WebApi.Models
{
    public class GetCustomersResponse : IEnumerable<GetCustomersResponseItem>
    {
        private readonly IEnumerable<ICustomer> _customers;

        public GetCustomersResponse(IEnumerable<ICustomer> customers)
        {
            _customers = customers ?? throw new ArgumentNullException(nameof(customers));
        }

        public IEnumerator<GetCustomersResponseItem> GetEnumerator()
        {
            return _customers.Select(x =>
            {
                var item = new GetCustomersResponseItem();
                x.Write(item);
                return item;
            }).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}