﻿using DomainLayer.Models;
using RepositoryLayer.RespositoryPattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesLayer.CustomerService
{
    public class CustomerService : ICustomerService
    {
        #region Property
        private IRepository<Customer> _repository;
        #endregion

        #region Constructor
        public CustomerService(IRepository<Customer> repository)
        {
            _repository = repository;
        }
        #endregion

        public IEnumerable<Customer> GetAllCustomers()
        {
            return _repository.GetAll();
        }

        public Customer GetCustomer(Guid id)
        {
            return _repository.Get(id);
        }

        public void InsertCustomer(Customer customer)
        {
            _repository.Insert(customer);
            _repository.SaveChanges();
        }
        public void UpdateCustomer(Customer customer)
        {
            _repository.Update(customer);
        }

        public void DeleteCustomer(Guid id)
        {
            Customer customer = GetCustomer(id);
            _repository.Remove(customer);
            _repository.SaveChanges();
        }
    }
}
