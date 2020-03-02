using Domain;

namespace WebApi.Models
{
    public class GetCustomersResponseItem : Media
    {
        public string FirstName { get; private set; }

        public string LastName { get; private set; }
    }
}