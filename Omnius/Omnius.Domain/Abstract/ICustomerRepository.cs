using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Omnius.Domain.Entities;


namespace Omnius.Domain.Abstract
{
    public interface ICustomerRepository
    {
        void Create(Customer customer);
        void Delete(int id);
        Customer Get(int id);
        IEnumerable<Customer> GetCustomers();
        IEnumerable<Customer> GetCustomers(int pageNumber, int pageSize);
        void Update(Customer customer);
        int GetNumberOfCustomers();
    }
}
