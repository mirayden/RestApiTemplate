using System;
using System.Net.Mime;
using Domain;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Produces(MediaTypeNames.Application.Json)]
    public class CustomerController : ControllerBase
    {
        private ICustomers _customers;
        
        public CustomerController(ICustomers customers)
        {
            _customers = customers ?? throw new ArgumentNullException(nameof(customers));
        }

        [HttpGet]
        public GetCustomersResponse GetCustomers()
        {
            return new GetCustomersResponse(_customers.All());
        }
        
        [HttpPut]
        public void NewCustomer(NewCustomerRequest request)
        {
            _customers.AddCustomer(request.FirstName, request.LastName);
        }
    }
}