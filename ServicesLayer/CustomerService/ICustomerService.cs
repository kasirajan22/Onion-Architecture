
using DomainLayer.Models;
using System;
using System.Collections.Generic;

namespace ServicesLayer.CustomerService
{
   public interface ICustomerService
    {
        IEnumerable<Customer> GetAllCustomers();
        Customer GetCustomer(Guid id);
        void InsertCustomer(Customer customer);
        void UpdateCustomer(Customer customer);
        void DeleteCustomer(Guid id);
    }
}
