using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Omnius.Domain.Entities;
using Omnius.Domain.Abstract;

namespace Omnius.UI.Components
{
    public class Contacts: ViewComponent
    {
        IEnumerable<Contact> contacts;
        ICustomerRepository repo;


        public Contacts(ICustomerRepository r)
        {
            repo = r;
        }
     
        public IViewComponentResult Invoke(Customer c)
        {
            contacts = repo.GetContacts(c.ID);
            return View("ContactList",contacts);
        }
    }
}
