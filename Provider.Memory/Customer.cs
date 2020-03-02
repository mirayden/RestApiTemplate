using System;
using Domain;

namespace Provider.Memory
{
    public class Customer: ICustomer
    {
        private readonly string _firstName;

        private readonly string _lastName;

        public Customer(string firstName, string lastName)
        {
            _firstName = firstName ?? throw new ArgumentNullException(nameof(firstName));
            _lastName = lastName ?? throw new ArgumentNullException(nameof(lastName));
        }
        
        public void Write(Media media)
        {
            media.Write("FirstName", _firstName);
            media.Write("LastName", _lastName);
        }
    }
}