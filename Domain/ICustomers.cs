using System.Collections.Generic;

namespace Domain
{
    public interface ICustomers
    {
        void AddCustomer(string firstName, string lastName);

        IEnumerable<ICustomer> All();
    }
}