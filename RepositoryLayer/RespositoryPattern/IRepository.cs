using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryLayer.RespositoryPattern
{
   public interface IRepository<T> where T: Customer
    {
        IEnumerable<T> GetAll();
        T Get(Guid Id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Remove(T entity);
        void SaveChanges();
    }
}
