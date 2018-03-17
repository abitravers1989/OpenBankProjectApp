using System;
using System.Collections.Generic;
namespace SantWebAPI.Customers
{
    public interface ICustomer
    {
        IEnumerable<string> GetCustomerData();

        IEnumerable<string> ReadCustomerAccountInfo();
    }
}
