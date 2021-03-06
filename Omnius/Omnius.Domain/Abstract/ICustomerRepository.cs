﻿using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Omnius.Domain.Entities;


namespace Omnius.Domain.Abstract
{
    public interface ICustomerRepository
    {
        int Create(Customer customer);
        void Delete(int id);
        Customer Get(int id);
        IEnumerable<Customer> GetCustomers();
        IEnumerable<Customer> GetCustomers(int pageNumber, int pageSize);
        IEnumerable<Customer> GetCustomers(int pageNumber, int pageSize, string familyNamefilter);
        void Update(Customer customer);
        int GetNumberOfCustomers(string familyNameFilter);
        int GetNumberOfCustomers();

        // То, что связано с Контактами. Доступ через репозиторий Потребителя, 
        // т.к. не имеет своей ценности вне него
        // Возможно придется переделать
        IEnumerable<Contact> GetContacts(int id); //id - идентификатор Потребителя
        void CreateContact(Contact contact);
        Contact GetContact(int id);
        void UpdateContact(Contact contact);
        void DeleteContact(int id);
    }
}
