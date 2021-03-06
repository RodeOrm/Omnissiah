﻿using Microsoft.AspNetCore.Mvc;
using Omnius.Domain.Entities;
using Omnius.Domain.Abstract;
using System.Collections.Generic;
using Omnius.UI.Models;
using System;

namespace Omnius.UI.Controllers
{
    public class CustomerController : Controller
    {
        ICustomerRepository repo;
        public CustomerController(ICustomerRepository r)
        {
            repo = r;
        }

        public ActionResult List(int page = 1, string familyNameFilter = "")
        {

            int pageSize = 15;
            string currentFamilyName;

            if (familyNameFilter == "")
            { currentFamilyName = familyNameFilter;}
            else
            { currentFamilyName = String.Concat("%", familyNameFilter, "%"); }

            var count = repo.GetNumberOfCustomers(currentFamilyName);
    
            PageViewModel pageViewModel = new PageViewModel(count, page, pageSize, familyNameFilter); 
            var items = repo.GetCustomers(pageSize, pageViewModel.PageNumber, currentFamilyName);

            CustomerViewModel ViewModel = new CustomerViewModel
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
                customer.ID = repo.Create(customer);
                return RedirectToAction("Edit", new { id = customer.ID });
            }
            else
                return View(customer);
            ;
        }

        public ActionResult Edit(int id, int currentPage)
        {
            Customer customer = repo.Get(id);
            customer.Contacts = repo.GetContacts(customer.ID);
          

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

		[HttpGet]
		public ActionResult EditContact(int id)
		{
			Contact contact = repo.GetContact(id);
			Contact contact_pre = contact;

			if (contact != null)
			{
				return View(contact);
			}
			else
			{
				return NotFound();
			}
		}

		[HttpPost]
		public ActionResult EditContact(Contact contact)
		{
			if (ModelState.IsValid)
			{
				repo.UpdateContact(contact);
				return RedirectToAction("Edit", new { id = contact.CustomerID });
			}
			else
				return View(contact);
			;
		}
	}
}