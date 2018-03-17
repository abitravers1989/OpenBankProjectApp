using System;
using SantWebAPI.Customers;
using System.Collections.Generic;
using System.Text;

namespace SantWebAPI.Customers
{
    public class Customer : ICustomer
    {

        public IEnumerable<string> GetCustomerData(){
            return new string[] { "sheep", "pencilcase" };
        }

        public IEnumerable<string> ReadCustomerAccountInfo(){
            var customerData = System.IO.File.ReadAllText(@"/transactioninfo.txt");
            return new string[] { customerData };
        }
    }
}
