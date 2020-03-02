using System;
using System.ComponentModel.DataAnnotations;

namespace WebApi.Models
{
    public class NewCustomerRequest
    {
        [JsonConstructor]
        public NewCustomerRequest(string firstName, string fastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        
        [Required]
        public string FirstName { get; }

        [Required]
        public string LastName { get; }
    }
}
