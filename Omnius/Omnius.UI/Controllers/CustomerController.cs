using Microsoft.AspNetCore.Mvc;
using Omnius.Domain.Entities;
using Omnius.Domain.Abstract;
using System.Collections.Generic;
using Omnius.UI.Models;

namespace Omnius.UI.Controllers
{
    public class CustomerController : Controller
    {
        ICustomerRepository repo;
        public CustomerController(ICustomerRepository r)
        {
            repo = r;
        }

        public ActionResult List(int page = 1)
        {

            int pageSize = 15;

            var count = repo.GetNumberOfCustomers();
    
            PageViewModel pageViewModel = new PageViewModel(count, page, pageSize); 
            var items = repo.GetCustomers(pageSize, pageViewModel.PageNumber);

            IndexViewModel ViewModel = new IndexViewModel
            {
                PageViewModel = pageViewModel,
                Customers = items
            };
            
            return View(ViewModel);
        }


        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Customer customer)
        {

            if (ModelState.IsValid)
            {
                repo.Create(customer);
                return RedirectToAction("List");
            }
            else
                return View(customer);
            ;
        }

        public ActionResult Edit(int id, int currentPage)
        {
            Customer customer = repo.Get(id);
            customer.Contacts = repo.GetContacts(customer);
          

            if (customer != null)
                return View(customer);
            return NotFound();
        }

        [HttpPost]
        public ActionResult Edit(Customer customer, int currentPage)
        {
            if (ModelState.IsValid)
            {
                repo.Update(customer);
                return RedirectToAction("List", currentPage);
            }
            else
                return View(customer);
            ;
        }

        [HttpGet]
        [ActionName("Delete")]
        public ActionResult ConfirmDelete(int id)
        {
            Customer customer = repo.Get(id);
            if (customer != null)
                return View(customer);
            return NotFound();
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            repo.Delete(id);
            return RedirectToAction("List");
        }

        [HttpGet]
        public ActionResult CreateContact(int customerID)
        {
            Contact newContact = new Contact { CustomerID = customerID };
            return View(newContact);
        }

        [HttpPost]
        public ActionResult CreateContact(Contact contact)
        {

            if (ModelState.IsValid)
            {
                repo.CreateContact(contact);
                return RedirectToAction("Edit", new { id = contact.CustomerID });
            }
            else
                return View("CreateContact");
            ;
        }

        [HttpGet]
        [ActionName("DeleteContact")]
        public ActionResult ConfirmDeleteContact(int id)
        {
            Contact contact = repo.GetContact(id);
            if (contact != null)
                return View(contact);
            return NotFound();
        }

        [HttpPost]
        public ActionResult DeleteContact(int id)
        {
            repo.DeleteContact(id);
            return RedirectToAction("List");
        }



    }
}