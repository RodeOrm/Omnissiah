using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Omnius.Domain.Entities;
using Omnius.Domain.Abstract;

namespace Omnius.Domain.Concrete
{
    public class CustomerRepository : ICustomerRepository
    {
        string connectionString = null;
        public CustomerRepository(string conn)
        {
            connectionString = conn;
        }
        public IEnumerable<Customer> GetCustomers()
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query<Customer>("SELECT * FROM Administratum.dbo.Customers").ToList();
            }
        }

        public IEnumerable<Customer> GetCustomers(int pageSize, int pageNumber)
        {
            IEnumerable<Customer> customers = null;

            using (IDbConnection db = new SqlConnection(connectionString))
            {
                string sqlQuery = ("SELECT * FROM Administratum.dbo.Customers " +
                    "ORDER BY ID OFFSET @PageSize * (@PageNumber - 1) " +
                    "ROWS FETCH NEXT @PageSize ROWS ONLY");

                customers = db.Query<Customer>(sqlQuery, new {PageNumber = pageNumber, PageSize = pageSize});

                return customers;
            }
        }

        public int GetNumberOfCustomers()
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query<int>("SELECT COUNT(*) FROM Administratum.dbo.Customers").FirstOrDefault();
            }
        }

        public Customer Get(int id)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query<Customer>("SELECT * FROM Administratum.dbo.Customers WHERE Id = @id", new { id }).FirstOrDefault();
            }
        }

        public void Create(Customer customer)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                var sqlQuery = "INSERT INTO Administratum.dbo.Customers " +
                                        "(Name, FamilyName, PaternalName, FirstCase, SecondCase, Sex) " +
                                "VALUES (@Name, @FamilyName, @PaternalName, @FirstCase, @SecondCase, @Sex)";
                db.Execute(sqlQuery, customer);

                // если мы хотим получить id добавленного пользователя
                //var sqlQuery = "INSERT INTO Customers (Name) VALUES(@Name); SELECT CAST(SCOPE_IDENTITY() as int)";
                //int? customerId = db.Query<int>(sqlQuery, customer).FirstOrDefault();
                //customer.Id = customerId.Value;
            }
        }

        public void Update(Customer customer)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                var sqlQuery = "UPDATE Administratum.dbo.Customers " +
                                "SET Name = @Name, FamilyName = @FamilyName, PaternalName = @PaternalName, Sex = @Sex, DateOfBirth = @DateOfBirth " +
                                "WHERE Id = @Id";
                db.Execute(sqlQuery, customer);
            }
        }

        public void Delete(int id)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                var sqlQuery = "DELETE FROM Administratum.dbo.Customers WHERE Id = @id";
                db.Execute(sqlQuery, new { id });
            }
        }
    }
}
