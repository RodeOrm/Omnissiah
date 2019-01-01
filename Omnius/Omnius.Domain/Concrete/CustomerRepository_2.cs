using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Omnius.Domain.Entities;
using Omnius.Domain.Abstract;

namespace Omnius.Domain.Concrete
{
    public partial class CustomerRepository : ICustomerRepository
    {
        public IEnumerable<Contact> GetContacts(int id)
        {
            IEnumerable<Contact> contacts = null;

            using (IDbConnection db = new SqlConnection(connectionString))
            {
                string sqlQuery = ("SELECT co.* FROM Administratum.dbo.Customers AS c " +
                    "INNER JOIN Administratum.dbo.CustomerContacts AS co " +
                    "ON c.ID = co.CustomerID AND c.ID = @Id");

                contacts = db.Query<Contact>(sqlQuery, new { Id = id});

                return contacts;
            }
        }


        public void CreateContact(Contact contact)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                var sqlQuery = "INSERT INTO Administratum.dbo.CustomerContacts" +
                                        "(ContactTypeID, CustomerID, Value) " +
                                "VALUES (@ContactTypeID, @CustomerID, @Value)";
                db.Execute(sqlQuery, contact);

                // если мы хотим получить id добавленного контакта
                //var sqlQuery = ""INSERT INTO Administratum.dbo.СustomerContacts" +
                //"(ContactTypeID, CustomerID, Value) " +
                //"VALUES (@ContactTypeID, @CustomerID, @Value)"; SELECT CAST(SCOPE_IDENTITY() as int)";
                //int? contactId = db.Query<int>(sqlQuery, contact).FirstOrDefault();
                //contact.Id = contactId.Value;
            }
        }

        public Contact GetContact(int id)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query<Contact>("SELECT * FROM Administratum.dbo.CustomerContacts WHERE Id = @id", new { id }).FirstOrDefault();
            }
        }

        public void UpdateContact(Contact contact)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                var sqlQuery = "UPDATE Administratum.dbo.CustomerContacts " +
                               "SET Value = @Value " +
							   "WHERE ID = @Id";
                db.Execute(sqlQuery, contact);

                // если мы хотим получить id добавленного контакта
                //var sqlQuery = ""INSERT INTO Administratum.dbo.СustomerContacts" +
                //"(ContactTypeID, CustomerID, Value) " +
                //"VALUES (@ContactTypeID, @CustomerID, @Value)"; SELECT CAST(SCOPE_IDENTITY() as int)";
                //int? contactId = db.Query<int>(sqlQuery, contact).FirstOrDefault();
                //contact.Id = contactId.Value;
            }
        }
        public void DeleteContact(int id)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                var sqlQuery = "DELETE FROM Administratum.dbo.CustomerContacts WHERE Id = @id";
                db.Execute(sqlQuery, new { id });
            }
        }


    }
}
