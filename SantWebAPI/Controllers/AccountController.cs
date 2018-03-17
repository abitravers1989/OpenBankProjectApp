using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using SantWebAPI.Customers;




namespace SantWebAPI.Controllers
{
    [Route("api/customerInfo")]
    public class TweetController : Controller
    {
        public ICustomer _customer;

        public TweetController()
        {
            _customer = new Customer();  
        }


        [HttpGet]
        public IEnumerable<string> Get()
        {
            var customerAccountResults = _customer.ReadCustomerAccountInfo();
            return customerAccountResults;
        }


    }
}
