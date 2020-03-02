using System;
using System.ComponentModel.DataAnnotations;

namespace WebApi.Models
{
    public class NewCustomerRequest
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }
    }
}