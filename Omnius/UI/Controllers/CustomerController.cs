﻿using Microsoft.AspNetCore.Mvc;
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

            int pageSize = 3;

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
   
       

        public ActionResult Details(int id)
        {
            Customer Customer = repo.Get(id);
            if (Customer != null)
                return View(Customer);
            return NotFound();
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

        public ActionResult Edit(int id)
        {
            Customer customer = repo.Get(id);
            if (customer != null)
                return View(customer);
            return NotFound();
        }

        [HttpPost]
        public ActionResult Edit(Customer customer)
        {
            if (ModelState.IsValid)
            {
                repo.Update(customer);
                return RedirectToAction("List");
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
    }
}